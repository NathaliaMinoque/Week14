using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Week_14
{
    public partial class FormQuizPanda : Form
    {
        public FormQuizPanda()
        {
            InitializeComponent();
        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            int c = 0;
            string lcasekalimat = textBoxKalimat.Text;
            string kalimat = lcasekalimat.ToUpper();
            string lcasedari = textBoxHuruf.Text;
            string dari = lcasedari.ToUpper();
            string lcasemenjadi = textBoxMenjadi.Text;
            string menjadi = lcasemenjadi.ToUpper();

            string daftarhuruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string konversi = "";
            string[] huruf = new string[26];
            huruf[0] = "A";
            huruf[1] = "B";
            huruf[2] = "C";
            huruf[3] = "D";
            huruf[4] = "E";
            huruf[5] = "F";
            huruf[6] = "G";
            huruf[7] = "H";
            huruf[8] = "I";
            huruf[9] = "J";
            huruf[10] = "K";
            huruf[11] = "L";
            huruf[12] = "M";
            huruf[13] = "N";
            huruf[14] = "O";
            huruf[15] = "P";
            huruf[16] = "Q";
            huruf[17] = "R";
            huruf[18] = "S";
            huruf[19] = "T";
            huruf[20] = "U";
            huruf[21] = "V";
            huruf[22] = "W";
            huruf[23] = "X";
            huruf[24] = "Y";
            huruf[25] = "Z";

            while (dari != huruf[c])
            {
                c++;
            }
            int simpan1 = c;
            c = 0;

            while (menjadi != huruf[c])
            {
                c++;
            }
            int simpan2 = c;
            int hasil = 0;           
            int selisih = simpan2 - simpan1;
            for (int i = 0; i < kalimat.Length; i++)
            {
                c = 0;
                if(kalimat[i] != ' ')
                {
                    while (kalimat[i] != daftarhuruf[c])
                    {
                        c++;
                    }
                    hasil = c + selisih;
                    if (hasil >= 0 && hasil <= 25)
                    {
                        konversi = konversi + daftarhuruf[hasil];
                    }
                    else if (hasil > 25)
                    {
                        konversi = konversi + daftarhuruf[hasil - 26];
                    }
                    else if (hasil < 25)
                    {
                        konversi = konversi + daftarhuruf[hasil + 26];
                    }
                }
                else if(kalimat[i] == ' ')
                {
                    konversi = konversi + " ";
                }
            }
            labelKonversi.Text = konversi;
        }
    }
}
