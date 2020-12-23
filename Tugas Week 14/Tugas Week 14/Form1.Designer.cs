
namespace Tugas_Week_14
{
    partial class FormQuizPanda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelKalimat = new System.Windows.Forms.Label();
            this.labelHuruf = new System.Windows.Forms.Label();
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.textBoxHuruf = new System.Windows.Forms.TextBox();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.textBoxMenjadi = new System.Windows.Forms.TextBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.labelKonversi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKalimat
            // 
            this.labelKalimat.AutoSize = true;
            this.labelKalimat.Location = new System.Drawing.Point(71, 50);
            this.labelKalimat.Name = "labelKalimat";
            this.labelKalimat.Size = new System.Drawing.Size(138, 20);
            this.labelKalimat.TabIndex = 0;
            this.labelKalimat.Text = "Masukkan Kalimat";
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(71, 117);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(126, 20);
            this.labelHuruf.TabIndex = 1;
            this.labelHuruf.Text = "Masukkan Huruf";
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Location = new System.Drawing.Point(209, 50);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(362, 26);
            this.textBoxKalimat.TabIndex = 2;
            // 
            // textBoxHuruf
            // 
            this.textBoxHuruf.Location = new System.Drawing.Point(209, 114);
            this.textBoxHuruf.Name = "textBoxHuruf";
            this.textBoxHuruf.Size = new System.Drawing.Size(100, 26);
            this.textBoxHuruf.TabIndex = 3;
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(394, 117);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(64, 20);
            this.labelMenjadi.TabIndex = 4;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // textBoxMenjadi
            // 
            this.textBoxMenjadi.Location = new System.Drawing.Point(471, 114);
            this.textBoxMenjadi.Name = "textBoxMenjadi";
            this.textBoxMenjadi.Size = new System.Drawing.Size(100, 26);
            this.textBoxMenjadi.TabIndex = 5;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(209, 175);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(362, 36);
            this.buttonKonversi.TabIndex = 6;
            this.buttonKonversi.Text = "Konversi!";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(75, 262);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(48, 20);
            this.labelHasil.TabIndex = 7;
            this.labelHasil.Text = "Hasil:";
            // 
            // labelKonversi
            // 
            this.labelKonversi.AutoSize = true;
            this.labelKonversi.Location = new System.Drawing.Point(205, 262);
            this.labelKonversi.Name = "labelKonversi";
            this.labelKonversi.Size = new System.Drawing.Size(13, 20);
            this.labelKonversi.TabIndex = 8;
            this.labelKonversi.Text = " ";
            // 
            // FormQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKonversi);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.textBoxMenjadi);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.textBoxHuruf);
            this.Controls.Add(this.textBoxKalimat);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.labelKalimat);
            this.Name = "FormQuizPanda";
            this.Text = "Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKalimat;
        private System.Windows.Forms.Label labelHuruf;
        private System.Windows.Forms.TextBox textBoxKalimat;
        private System.Windows.Forms.TextBox textBoxHuruf;
        private System.Windows.Forms.Label labelMenjadi;
        private System.Windows.Forms.TextBox textBoxMenjadi;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label labelKonversi;
    }
}

