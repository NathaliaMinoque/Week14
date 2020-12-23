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
            int c = 1;
            string kalimat = textBoxKalimat.Text;
            string dari = textBoxHuruf.Text;
            string menjadi = textBoxMenjadi.Text;
            //int[] simpan = new int[2];
            string konversi = "";
            string[] huruf = new string[27];
            huruf[1] = "A";
            huruf[2] = "B";
            huruf[3] = "C";
            huruf[4] = "D";
            huruf[5] = "E";
            huruf[6] = "F";
            huruf[7] = "G";
            huruf[8] = "H";
            huruf[9] = "I";
            huruf[10] = "J";
            huruf[11] = "K";
            huruf[12] = "L";
            huruf[13] = "M";
            huruf[14] = "N";
            huruf[15] = "O";
            huruf[16] = "P";
            huruf[17] = "Q";
            huruf[18] = "R";
            huruf[19] = "S";
            huruf[20] = "T";
            huruf[21] = "U";
            huruf[22] = "V";
            huruf[23] = "W";
            huruf[24] = "X";
            huruf[25] = "Y";
            huruf[26] = "Z";

            kalimat.ToUpper();
            dari.ToUpper();
            menjadi.ToUpper();

            while(dari != huruf[c])
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

            int selisih = simpan1 - simpan2;
            
            for (int i=1; i<=kalimat.Length; i++)
            {
                c = 0;
                while (kalimat[i] != huruf[c])
                {
                    c++;
                }
                konversi = konversi + kalimat[c + selisih];
            }
            labelKonversi.Text = konversi;
        }
    }
}
