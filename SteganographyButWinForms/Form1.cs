using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteganographyButWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap original;
        Bitmap bitmap;

        public static Color[] ConvertToColors(string msg)
        {
            while (msg.Length % 3 != 0)
            {
                msg += '\0';
            }

            Color[] color = new Color[msg.Length / 3];

            for (int i = 0, count = 0; i < msg.Length && count < color.Length; i += 3, count++)
            {
                int r = msg[i];
                int g = msg[i + 1];
                int b = msg[i + 2];

                //color[count].R = msg[i];
                //color[count].G = msg[i + 1];
                //color[count].B = msg[i + 2];

                color[count] = Color.FromArgb(r, g, b);
            }

            return color;
        }

        public static string DecryptNicholas(Bitmap bitmap)
        {
            string decryptedMsg = "";

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color color = bitmap.GetPixel(x, y);

                    if (color.A != 0 && color.R == 255 && color.G == 255 && color.B == 255)
                    {
                        //end of message
                        return decryptedMsg;
                    }
                    else
                    {
                        decryptedMsg += (char)color.R;
                        decryptedMsg += (char)color.G;
                        decryptedMsg += (char)color.B;
                    }
                }
            }
            return decryptedMsg;
        }

        private static Color PackChar(Color color, char c)
        {
            byte toHide = (byte)c;
            byte r = color.R;
            byte g = color.G;
            byte b = color.B;

            //cast to uint to do logical shift instead of arithmetic
            byte high3 = (byte)((uint)(toHide & 0b1110_0000) >> 5);
            byte mid2 = (byte)((uint)(toHide & 0b0001_1000) >> 3);
            byte low3 = (byte)(toHide & 0b0000_0111);

            r = (byte)(r & 0b1111_1000);
            r = (byte)(r | high3);

            g = (byte)(g & 0b1111_1100);
            g = (byte)(g | mid2);

            b = (byte)(b & 0b1111_1000);
            b = (byte)(b | low3);

            return Color.FromArgb(color.A, r, g, b);
        }

        private static char UnpackChar(Color color)
        {
            byte r = color.R;
            byte g = color.G;
            byte b = color.B;

            r = (byte)(r & 0b0000_0111);
            r = (byte)(r << 5);

            g = (byte)(g & 0b0000_0011);
            g = (byte)(g << 3);

            b = (byte)(b & 0b000_0111);

            char c = (char)(r | g | b);
            return c;
        }

        public static Bitmap EncryptSneakier(Bitmap bitmap, string message)
        {
            //Color pixel = Color.FromArgb(0xfa0d67);
            message += '\0';

            for (int i = 0; i < message.Length; i++)
            {
                int row = i / bitmap.Width;
                int col = i - (row * bitmap.Width);
                Color encryptedColor = PackChar(bitmap.GetPixel(col, row), message[i]);
                bitmap.SetPixel(col, row, encryptedColor);
            }

            return bitmap;
        }

        public static string DecryptSneakier(Bitmap bitmap)
        {
            string decryptedMsg = "";

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    char decrypted = UnpackChar(bitmap.GetPixel(x, y));
                    if (decrypted == '\0')
                    {
                        return decryptedMsg;
                    }
                    else
                    {
                        decryptedMsg += decrypted;
                    }
                }
            }

            return decryptedMsg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User.Enabled = true;

            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                original = new Bitmap(openFileDialog1.FileName);
                bitmap = (Bitmap)original.Clone();
                pictureBox1.Image = original;
            }

            //bitmap.Width
            //bitmap.SetPixel();
        }


        private void confirmButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            string msg = userMessage.Text;
            //Color[] color = ConvertToColors(msg);
            bitmap = (Bitmap)original.Clone();

            //for (int i = 0, y = 0; i < color.Length; i++, y++)
            //{
            //    for (int x = 0; x < bitmap.Width; x++)
            //    {
            //        bitmap.SetPixel(x, y, color[i]);
            //    }
            //}
            bitmap = EncryptSneakier(bitmap, msg);

            pictureBox1.Image = bitmap;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            //string decryptedMsg = DecryptNicholas(bitmap);
            string decryptedMsg = DecryptSneakier(bitmap);
            decryptedMessage.Text = decryptedMsg;
        }

        private void imageChooser_Click_1(object sender, EventArgs e)
        {
            // original = null;
            //bitmap = null;
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                original = new Bitmap(openFileDialog1.FileName);
                bitmap = (Bitmap)original.Clone();
                pictureBox1.Image = original;
            }
        }

        private void fileSaver_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (System.IO.File.Exists(saveFileDialog1.FileName))
                {
                    System.IO.File.Delete(saveFileDialog1.FileName);
                }
               ((Bitmap)bitmap.Clone()).Save(saveFileDialog1.FileName);
            }
        }
    }
}
