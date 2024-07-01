
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageEncryptionTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptImage(string inputPath, string outputPath, int key)
        {
            Bitmap bitmap = new Bitmap(inputPath);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    Color encryptedPixel = Color.FromArgb(
                        (pixel.R + key) % 256,
                        (pixel.G + key) % 256,
                        (pixel.B + key) % 256
                    );
                    bitmap.SetPixel(x, y, encryptedPixel);
                }
            }
            bitmap.Save(outputPath);
        }

        private void DecryptImage(string inputPath, string outputPath, int key)
        {
            Bitmap bitmap = new Bitmap(inputPath);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    Color decryptedpixel = Color.FromArgb(
                        (pixel.R - key + 256) % 256,
                        (pixel.G - key + 256) % 256,
                        (pixel.B - key + 256) % 256
                    );
                    bitmap.SetPixel(x, y, decryptedpixel);
                }
            }
            bitmap.Save(outputPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseInput_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInputPath.Text = openFileDialog.FileName;
            }
        }

        private void btnBrowseOutput_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = saveFileDialog.FileName;
            }
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtKey.Text, out int key))
            {
                EncryptImage(txtInputPath.Text, txtOutputPath.Text, key);
                MessageBox.Show("Image Encrypted Successfully..");
            }

            else
            {
                MessageBox.Show("Please Enter a Valid Integer Key..");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtKey.Text, out int key))
            {
                DecryptImage(txtInputPath.Text, txtOutputPath.Text, key);
                MessageBox.Show("Image Decrypted Successfully...");
            }
            else
            {
                MessageBox.Show("Please enter a Valid Integer Key..");
            }
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
