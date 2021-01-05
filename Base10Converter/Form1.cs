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
                //Base10ToBinary(base10);
                //Base10ToOctal(base10);
            }
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
                MessageBox.Show("Entry must be a number");
                return false;
            }
        }
    }
}
