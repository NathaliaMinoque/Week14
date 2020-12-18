using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week14praktikumm
{
    public partial class FormString : Form
    {
        public FormString()
        {
            InitializeComponent();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Tolong isi terlebih dahulu!");
            }
            string input = textBoxInput.Text;
            string cek = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                cek = cek + input[i];
            }
            labelOutput.Text = cek;
        }

        private void buttonUrutkan_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Tolong isi terlebih dahulu!");
            }
            string input2 = textBoxInput.Text;
            string symbol = "";
            char[] sort = input2.ToCharArray();
            string upper = "";
            string lower = "";
            string number = "";
            Array.Sort(sort);
            //Array.Reverse(sort);
            for(int i=0; i<=input2.Length-1; i++)
            {
                if (char.IsSymbol(sort[i]) == true || sort[i]=='!' || sort[i] == '@' || sort[i] == '-' || sort[i] == '~' || sort[i] == '$' || sort[i] == '#' || sort[i] == '%' || sort[i] == '^' || sort[i] == '&' || sort[i] == '*' || sort[i] == '(' || sort[i] == ')' || sort[i] == '_' || sort[i] == '=' || sort[i] == '[' || sort[i] == ']' || sort[i] == '{' || sort[i] == '}' || sort[i] == ':' || sort[i] == ';' || sort[i] == '"' || sort[i] == '<' || sort[i] == '>' || sort[i] == ',' || sort[i] == '.' || sort[i] == '?' || sort[i] == '/')
                {
                    symbol = symbol + sort[i];
                }
                if (char.IsUpper(sort[i]) == true)
                {
                    upper = upper + sort[i];
                }
                if (char.IsLower(sort[i]) == true)
                {
                    lower = lower + sort[i];
                }                            
                if (char.IsNumber(sort[i]) == true)
                {
                    number = number + sort[i];
                }
            }
            labelOutput.Text = lower + upper + number + symbol;
        }
    }
}
