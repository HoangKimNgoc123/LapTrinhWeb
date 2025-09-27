// CaesarWin/Form1.cs
using System;
using System.Windows.Forms;
using CaesarLib;

namespace CaesarWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnProcess.Click += new EventHandler(btnProcess_Click);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Có thể để trống, hoặc xử lý gì đó nếu cần
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Có thể để trống, hoặc xử lý gì đó nếu cần
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text;
            int shift = (int)numShift.Value;

            CaesarCipher cc = new CaesarCipher();
            cc.InputText = text;
            cc.Shift = shift;

            if (cc.Process())
            {
                txtOutput.Text = "Encoded: " + cc.EncodedText + Environment.NewLine
                                + "Decoded: " + cc.DecodedText + Environment.NewLine;                             
            }
            else
            {
                txtOutput.Text = "Processing error.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numShift_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
