namespace CalculatorFormsApp
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.operasiHitung = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // operasiHitung
            // 
            this.operasiHitung.Cursor = System.Windows.Forms.Cursors.Default;
            this.operasiHitung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operasiHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.operasiHitung.FormattingEnabled = true;
            this.operasiHitung.Location = new System.Drawing.Point(119, 26);
            this.operasiHitung.Name = "operasiHitung";
            this.operasiHitung.Size = new System.Drawing.Size(121, 28);
            this.operasiHitung.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(17, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nilai B";
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNilaiA.Location = new System.Drawing.Point(119, 80);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(100, 26);
            this.txtNilaiA.TabIndex = 4;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNilaiB.Location = new System.Drawing.Point(119, 121);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(100, 26);
            this.txtNilaiB.TabIndex = 5;
            // 
            // btnHitung
            // 
            this.btnHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHitung.Location = new System.Drawing.Point(279, 114);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(100, 40);
            this.btnHitung.TabIndex = 6;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(13, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil";
            // 
            // hasil
            // 
            this.hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hasil.Location = new System.Drawing.Point(119, 180);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(100, 26);
            this.hasil.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 234);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operasiHitung);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox operasiHitung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hasil;
    }
}