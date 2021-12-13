
namespace MCD_SystemIOWinForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.btnPersonelKayder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtulke = new System.Windows.Forms.TextBox();
            this.txtfirma = new System.Windows.Forms.TextBox();
            this.txtemailAdres = new System.Windows.Forms.TextBox();
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPersonel);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Liste";
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.ItemHeight = 16;
            this.lstPersonel.Location = new System.Drawing.Point(6, 21);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(188, 388);
            this.lstPersonel.TabIndex = 0;
            this.lstPersonel.DoubleClick += new System.EventHandler(this.lstPersonel_DoubleClick);
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.Location = new System.Drawing.Point(18, 463);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(188, 23);
            this.btnPersonelGetir.TabIndex = 1;
            this.btnPersonelGetir.Text = "Personel Getir";
            this.btnPersonelGetir.UseVisualStyleBackColor = true;
            this.btnPersonelGetir.Click += new System.EventHandler(this.btnPersonelGetir_Click);
            // 
            // btnPersonelKayder
            // 
            this.btnPersonelKayder.Location = new System.Drawing.Point(18, 508);
            this.btnPersonelKayder.Name = "btnPersonelKayder";
            this.btnPersonelKayder.Size = new System.Drawing.Size(188, 23);
            this.btnPersonelKayder.TabIndex = 2;
            this.btnPersonelKayder.Text = "Personel Kaydet";
            this.btnPersonelKayder.UseVisualStyleBackColor = true;
            this.btnPersonelKayder.Click += new System.EventHandler(this.btnPersonelKayder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtulke);
            this.groupBox2.Controls.Add(this.txtfirma);
            this.groupBox2.Controls.Add(this.txtemailAdres);
            this.groupBox2.Controls.Add(this.txtsoyisim);
            this.groupBox2.Controls.Add(this.txtisim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(228, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 223);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Detay";
            // 
            // txtulke
            // 
            this.txtulke.Location = new System.Drawing.Point(110, 185);
            this.txtulke.Name = "txtulke";
            this.txtulke.Size = new System.Drawing.Size(122, 22);
            this.txtulke.TabIndex = 9;
            // 
            // txtfirma
            // 
            this.txtfirma.Location = new System.Drawing.Point(110, 145);
            this.txtfirma.Name = "txtfirma";
            this.txtfirma.Size = new System.Drawing.Size(122, 22);
            this.txtfirma.TabIndex = 8;
            // 
            // txtemailAdres
            // 
            this.txtemailAdres.Location = new System.Drawing.Point(110, 104);
            this.txtemailAdres.Name = "txtemailAdres";
            this.txtemailAdres.Size = new System.Drawing.Size(122, 22);
            this.txtemailAdres.TabIndex = 7;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(110, 66);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(122, 22);
            this.txtsoyisim.TabIndex = 6;
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(110, 26);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(122, 22);
            this.txtisim.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ülke:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Firma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPersonelKayder);
            this.Controls.Add(this.btnPersonelGetir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Button btnPersonelKayder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtulke;
        private System.Windows.Forms.TextBox txtfirma;
        private System.Windows.Forms.TextBox txtemailAdres;
        private System.Windows.Forms.TextBox txtsoyisim;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPersonel;
    }
}

