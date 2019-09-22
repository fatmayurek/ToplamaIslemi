namespace ToplamaIslemi
{
    partial class frmToplama
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
            this.tabToplama = new System.Windows.Forms.TabPage();
            this.btnİleri = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.btnToplama = new System.Windows.Forms.Button();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.tabGenel = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lwLog = new System.Windows.Forms.ListView();
            this.tabToplama.SuspendLayout();
            this.tabGenel.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabToplama
            // 
            this.tabToplama.BackColor = System.Drawing.Color.GreenYellow;
            this.tabToplama.Controls.Add(this.btnİleri);
            this.tabToplama.Controls.Add(this.txtSonuc);
            this.tabToplama.Controls.Add(this.lblSonuc);
            this.tabToplama.Controls.Add(this.txtSayi2);
            this.tabToplama.Controls.Add(this.txtSayi1);
            this.tabToplama.Controls.Add(this.btnToplama);
            this.tabToplama.Controls.Add(this.lblSayi2);
            this.tabToplama.Controls.Add(this.lblSayi1);
            this.tabToplama.Location = new System.Drawing.Point(4, 25);
            this.tabToplama.Margin = new System.Windows.Forms.Padding(4);
            this.tabToplama.Name = "tabToplama";
            this.tabToplama.Padding = new System.Windows.Forms.Padding(4);
            this.tabToplama.Size = new System.Drawing.Size(798, 402);
            this.tabToplama.TabIndex = 0;
            this.tabToplama.Text = "Toplama";
            // 
            // btnİleri
            // 
            this.btnİleri.BackColor = System.Drawing.Color.OrangeRed;
            this.btnİleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİleri.Location = new System.Drawing.Point(394, 280);
            this.btnİleri.Name = "btnİleri";
            this.btnİleri.Size = new System.Drawing.Size(162, 53);
            this.btnİleri.TabIndex = 6;
            this.btnİleri.Text = "Ileri";
            this.btnİleri.UseVisualStyleBackColor = false;
            this.btnİleri.Click += new System.EventHandler(this.btnİleri_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(394, 215);
            this.txtSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(162, 22);
            this.txtSonuc.TabIndex = 3;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(221, 223);
            this.lblSonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(67, 20);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi2.Location = new System.Drawing.Point(387, 63);
            this.txtSayi2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(169, 27);
            this.txtSayi2.TabIndex = 1;
            this.txtSayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi2_KeyPress);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi1.Location = new System.Drawing.Point(387, 28);
            this.txtSayi1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(169, 27);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi1_KeyPress);
            // 
            // btnToplama
            // 
            this.btnToplama.BackColor = System.Drawing.Color.Gold;
            this.btnToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplama.Location = new System.Drawing.Point(387, 123);
            this.btnToplama.Margin = new System.Windows.Forms.Padding(4);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(169, 62);
            this.btnToplama.TabIndex = 2;
            this.btnToplama.Text = "Topla";
            this.btnToplama.UseVisualStyleBackColor = false;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi2.Location = new System.Drawing.Point(214, 68);
            this.lblSayi2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(95, 20);
            this.lblSayi2.TabIndex = 3;
            this.lblSayi2.Text = "İkinci Sayi";
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi1.Location = new System.Drawing.Point(214, 28);
            this.lblSayi1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(106, 20);
            this.lblSayi1.TabIndex = 1;
            this.lblSayi1.Text = "Birinci Sayi";
            // 
            // tabGenel
            // 
            this.tabGenel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGenel.Controls.Add(this.tabToplama);
            this.tabGenel.Controls.Add(this.tabLog);
            this.tabGenel.Location = new System.Drawing.Point(5, 2);
            this.tabGenel.Margin = new System.Windows.Forms.Padding(4);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.SelectedIndex = 0;
            this.tabGenel.Size = new System.Drawing.Size(806, 431);
            this.tabGenel.TabIndex = 5;
            this.tabGenel.Tag = "";
            // 
            // tabLog
            // 
            this.tabLog.BackColor = System.Drawing.Color.Plum;
            this.tabLog.Controls.Add(this.btnGeri);
            this.tabLog.Controls.Add(this.btnTemizle);
            this.tabLog.Controls.Add(this.lwLog);
            this.tabLog.Location = new System.Drawing.Point(4, 25);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(798, 402);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Loglama";
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Red;
            this.btnGeri.Location = new System.Drawing.Point(212, 329);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(114, 40);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Lime;
            this.btnTemizle.Location = new System.Drawing.Point(377, 326);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(103, 40);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lwLog
            // 
            this.lwLog.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lwLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lwLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lwLog.HideSelection = false;
            this.lwLog.Location = new System.Drawing.Point(3, 3);
            this.lwLog.Name = "lwLog";
            this.lwLog.Size = new System.Drawing.Size(719, 317);
            this.lwLog.TabIndex = 0;
            this.lwLog.UseCompatibleStateImageBehavior = false;
            this.lwLog.View = System.Windows.Forms.View.List;
            // 
            // frmToplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 487);
            this.Controls.Add(this.tabGenel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmToplama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama İşlemi";
            this.Load += new System.EventHandler(this.frmToplama_Load);
            this.Shown += new System.EventHandler(this.frmToplama_Shown);
            this.tabToplama.ResumeLayout(false);
            this.tabToplama.PerformLayout();
            this.tabGenel.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabToplama;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.TabControl tabGenel;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.ListView lwLog;
        private System.Windows.Forms.Button btnİleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnTemizle;
    }
}

