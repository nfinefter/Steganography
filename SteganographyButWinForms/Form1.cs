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


        private void Form1_Load(object sender, EventArgs e)
        {
            User.Enabled = true;

            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                bitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bitmap;
            }

            //bitmap.Width
            //bitmap.SetPixel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string msg = userMessage.Text;
            Color[] color = ConvertToColors(msg);

            for (int i = 0; i < color.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    bitmap.SetPixel(j, i, color[i]);
                }
                
            }
            
        }


    }
}
