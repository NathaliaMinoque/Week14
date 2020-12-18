
namespace week14praktikumm
{
    partial class FormString
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.buttonUrutkan = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(119, 74);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(369, 26);
            this.textBoxInput.TabIndex = 0;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(115, 41);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(46, 20);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "Input";
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(123, 118);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(111, 44);
            this.buttonReverse.TabIndex = 2;
            this.buttonReverse.Text = "REVERSE";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // buttonUrutkan
            // 
            this.buttonUrutkan.Location = new System.Drawing.Point(273, 118);
            this.buttonUrutkan.Name = "buttonUrutkan";
            this.buttonUrutkan.Size = new System.Drawing.Size(108, 44);
            this.buttonUrutkan.TabIndex = 3;
            this.buttonUrutkan.Text = "URUTKAN";
            this.buttonUrutkan.UseVisualStyleBackColor = true;
            this.buttonUrutkan.Click += new System.EventHandler(this.buttonUrutkan_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(119, 219);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(73, 20);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "OUTPUT";
            // 
            // FormString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonUrutkan);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInput);
            this.Name = "FormString";
            this.Text = "String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Button buttonUrutkan;
        private System.Windows.Forms.Label labelOutput;
    }
}

