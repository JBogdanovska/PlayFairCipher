using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            SecretTB.Text = string.Empty;
            InputTB.Text = string.Empty;
            OutputTB.Text = string.Empty;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SecretL_Click(object sender, EventArgs e)
        {

        }

        private void InputTextL_Click(object sender, EventArgs e)
        {

        }

        private void OutputTextL_Click(object sender, EventArgs e)
        {

        }

        private void Translate_Click(object sender, EventArgs e)
        {
            NullCheck();
            CipherKey();
        }
        private void Secret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsWhiteSpace(e.KeyChar)
            && !char.IsLetterOrDigit(e.KeyChar)
            && e.KeyChar != '!' && e.KeyChar != ':' && e.KeyChar != '?'
            && e.KeyChar != '.' && e.KeyChar != ';' && e.KeyChar != '-'
            && e.KeyChar != ',' && e.KeyChar != '_' && e.KeyChar != '('
            && e.KeyChar != ')' && e.KeyChar != '&' && e.KeyChar != '%'
            && e.KeyChar != '$' && e.KeyChar != '#')
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }

        private void OutputTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
            && !char.IsWhiteSpace(e.KeyChar)
            && !char.IsLetterOrDigit(e.KeyChar)
            && e.KeyChar != '!' && e.KeyChar != ':' && e.KeyChar != '?'
            && e.KeyChar != '.' && e.KeyChar != ';' && e.KeyChar != '-'
            && e.KeyChar != ',' && e.KeyChar != '_' && e.KeyChar != '('
            && e.KeyChar != ')' && e.KeyChar != '&' && e.KeyChar != '%'
            && e.KeyChar != '$' && e.KeyChar != '#')
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }
        public void CipherKey()
        {
            string key = SecretTB.Text;
            var keyLow = key.ToLower();
            var newKey = keyLow.Replace("j", "i");
            string cipherWord = new string(key.ToLower()
                                .Replace("j", "i")
                                .Distinct()
                                .ToArray());

            char[,] matrixCipher = new char[5, 5];
            int col = 0;
            int row = 0;
            string alpha = "abcdefghiklmnopqrstuvwxyz";
            string fullAlpha = cipherWord + alpha;
            var alphaSet = new HashSet<char>(fullAlpha);
            string finalText = new string(alphaSet.ToArray());
            foreach (var letter in finalText)
            {
                matrixCipher[row, col] = letter;
                col++;
                if (col == 5)
                {
                    col = 0;
                    row++;
                }
            }
            var text = InputTB.Text;

            OutputTB.Text = String.Format(.ToString());


        }

        public void NullCheck()
        {
            if (string.IsNullOrWhiteSpace(SecretTB.Text))
            {
                MessageBox.Show("Please input a cipherkey.");
            }
            if (string.IsNullOrWhiteSpace(InputTB.Text))
            {
                MessageBox.Show("Please input a sentence to cipher.");
            }
        }
    }
}
