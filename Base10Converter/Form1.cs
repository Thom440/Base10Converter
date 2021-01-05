using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base10Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (ValidInput(base10TextBox.Text))
            {
                UInt64 base10 = Convert.ToUInt64(base10TextBox.Text);
                Base10ToBinary(base10);
                Base10ToOctal(base10);
            }
        }

        /// <summary>
        /// Converts the base10 number to binary
        /// </summary>
        /// <param name="base10">The number to be converted to binary</param>
        private void Base10ToBinary(UInt64 base10)
        {
            UInt64 remainder = 0;

            string binary = "";

            do
            {
                remainder = base10 % 2;
                base10 /= 2;
                binary = remainder + binary;
            } while (base10 > 0);

            binaryTextBox.Text = binary;
        }

        /// <summary>
        /// Converts the number to Octal
        /// </summary>
        /// <param name="base10">The number to be converted to Octal</param>
        private void Base10ToOctal(UInt64 base10)
        {
            UInt64 i = ValueOfI(base10);

            string octal = "";

            do
            {
                octal += base10 / i;
                base10 = base10 % i;
                i /= 8;
            } while (i != 0);
            octalTextBox.Text = octal;
        }

        private UInt64 ValueOfI(UInt64 base10)
        {
            UInt64 i = 1;
            while (i * 8 <= base10 && i * 8 != 0)
            {
                i *= 8;
            }
            return i;
        }
        private bool ValidInput(string base10)
        {
            try
            {
                Convert.ToUInt64(base10);
                return true;
            }
            catch
            {
                MessageBox.Show("Entry must be a number between 0 and 18446744073709551615");
                return false;
            }
        }
    }
}
