using System;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Encrypt_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string method = methodComboBox.SelectedItem.ToString();

            switch (method)
            {
                case "DES":
                    string desEncryptedText = await EncryptDES(input);
                    encryptedTextBox.Text = desEncryptedText;
                    break;
                case "N-HASH":
                    string nHash = NHash.ComputeNHash(input);
                    encryptedTextBox.Text = nHash;
                    break;
                case "RC4":
                    string rc4EncryptedText = await EncryptRC4(input);
                    encryptedTextBox.Text = rc4EncryptedText;
                    break;
            }
        }


        private async Task<string> EncryptDES(string input)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                des.GenerateKey();
                des.GenerateIV();

                using (ICryptoTransform encryptor = des.CreateEncryptor())
                {
                    byte[] encryptedBytes = await Task.Run(() => PerformCryptography(inputBytes, encryptor));
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
        }

        private async Task<string> ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashedBytes = await Task.Run(() => sha256.ComputeHash(inputBytes));
                return BitConverter.ToString(hashedBytes).Replace("-", string.Empty);
            }
        }

        private async Task<string> EncryptRC4(string input)
        {
            byte[] key = GenerateRandomKey(16); // Генерируем случайный ключ длиной 16 байт
            using (RC4CryptoServiceProvider rc4 = new RC4CryptoServiceProvider(key))
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] encryptedBytes = await Task.Run(() => rc4.Encrypt(inputBytes));
                return Convert.ToBase64String(encryptedBytes);
            }
        }

        private byte[] GenerateRandomKey(int length)
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] key = new byte[length];
                rng.GetBytes(key);
                return key;
            }
        }
        private byte[] PerformCryptography(byte[] inputBytes, ICryptoTransform transform)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                {
                    cs.Write(inputBytes, 0, inputBytes.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
            }
        }


        public class RC4CryptoServiceProvider : IDisposable
        {
            private byte[] s;
            private byte[] key;
            private int i;
            private int j;

            public RC4CryptoServiceProvider(byte[] key)
            {
                this.key = key;
                Initialize();
            }

            private void Initialize()
            {
                s = new byte[256];
                for (int i = 0; i < 256; i++)
                {
                    s[i] = (byte)i;
                }

                int j = 0;
                for (int i = 0; i < 256; i++)
                {
                    j = (j + key[i % key.Length] + s[i]) & 255;
                    Swap(i, j);
                }

                i = 0;
                j = 0;
            }

            private void Swap(int i, int j)
            {
                byte temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }

            public byte[] Encrypt(byte[] input)
            {
                byte[] output = new byte[input.Length];
                for (int k = 0; k < input.Length; k++)
                {
                    i = (i + 1) & 255;
                    j = (j + s[i]) & 255;
                    Swap(i, j);
                    byte t = s[(s[i] + s[j]) & 255];
                    output[k] = (byte)(input[k] ^ t);
                }
                return output;
            }

            public void Dispose()
            {
                Array.Clear(s, 0, s.Length);
                Array.Clear(key, 0, key.Length);
                key = null;
            }
        }
        public class NHash
        {
            public static string ComputeNHash(string input)
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashedBytes = ComputeHash(inputBytes);
                return BitConverter.ToString(hashedBytes).Replace("-", string.Empty);
            }

            private static byte[] ComputeHash(byte[] input)
            {
               

                // В примере просто инвертируем каждый байт
                byte[] hashedBytes = new byte[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    hashedBytes[i] = (byte)~input[i];
                }

                return hashedBytes;
            }
        }

    }
}

