
namespace IEA_ErpProject102_Main.BilgiGirisİslemleri.Doktorlar
{
    partial class frmDoktorGirisEkrani
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
            this.txtHKoduBul = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMuaAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVnTc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVergiD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDokMail = new System.Windows.Forms.TextBox();
            this.txtDokTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDokAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDokUnvan = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDokCep = new System.Windows.Forms.MaskedTextBox();
            this.txtDokDep1 = new System.Windows.Forms.ComboBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.lblDoktorKodu = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtDokTip = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHKoduBul
            // 
            this.txtHKoduBul.Location = new System.Drawing.Point(17, 12);
            this.txtHKoduBul.Name = "txtHKoduBul";
            this.txtHKoduBul.Size = new System.Drawing.Size(427, 22);
            this.txtHKoduBul.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(21, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 4;
            this.label15.Text = "Doktor Tipi :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMuaAdres
            // 
            this.txtMuaAdres.Location = new System.Drawing.Point(852, 84);
            this.txtMuaAdres.Multiline = true;
            this.txtMuaAdres.Name = "txtMuaAdres";
            this.txtMuaAdres.Size = new System.Drawing.Size(317, 60);
            this.txtMuaAdres.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doktor Unvani :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHastAdres
            // 
            this.txtHastAdres.Location = new System.Drawing.Point(852, 16);
            this.txtHastAdres.Multiline = true;
            this.txtHastAdres.Name = "txtHastAdres";
            this.txtHastAdres.Size = new System.Drawing.Size(317, 62);
            this.txtHastAdres.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Adi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVnTc
            // 
            this.txtVnTc.Location = new System.Drawing.Point(852, 197);
            this.txtVnTc.Mask = "00000000000";
            this.txtVnTc.Name = "txtVnTc";
            this.txtVnTc.Size = new System.Drawing.Size(128, 22);
            this.txtVnTc.TabIndex = 16;
            this.txtVnTc.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(750, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vergi Dairesi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVergiD
            // 
            this.txtVergiD.Location = new System.Drawing.Point(852, 161);
            this.txtVergiD.Name = "txtVergiD";
            this.txtVergiD.Size = new System.Drawing.Size(193, 22);
            this.txtVergiD.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(713, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dok Hast Adresi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDokMail
            // 
            this.txtDokMail.Location = new System.Drawing.Point(123, 277);
            this.txtDokMail.Name = "txtDokMail";
            this.txtDokMail.Size = new System.Drawing.Size(193, 22);
            this.txtDokMail.TabIndex = 14;
            // 
            // txtDokTel
            // 
            this.txtDokTel.Location = new System.Drawing.Point(123, 197);
            this.txtDokTel.Mask = "(999) 000-0000";
            this.txtDokTel.Name = "txtDokTel";
            this.txtDokTel.Size = new System.Drawing.Size(124, 22);
            this.txtDokTel.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(695, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vergi No - Tc No :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSehir
            // 
            this.txtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(124, 132);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(193, 24);
            this.txtSehir.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(731, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 61);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dok Muayene Adres";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDokAdi
            // 
            this.txtDokAdi.Location = new System.Drawing.Point(123, 94);
            this.txtDokAdi.Name = "txtDokAdi";
            this.txtDokAdi.Size = new System.Drawing.Size(317, 22);
            this.txtDokAdi.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(21, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cep Telefonu";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(21, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor Tel : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDokUnvan
            // 
            this.txtDokUnvan.FormattingEnabled = true;
            this.txtDokUnvan.Location = new System.Drawing.Point(123, 54);
            this.txtDokUnvan.Name = "txtDokUnvan";
            this.txtDokUnvan.Size = new System.Drawing.Size(193, 24);
            this.txtDokUnvan.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(21, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Doktor Mail : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "Sehir :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Departmani";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDokCep
            // 
            this.txtDokCep.Location = new System.Drawing.Point(123, 236);
            this.txtDokCep.Mask = "(999) 000-0000";
            this.txtDokCep.Name = "txtDokCep";
            this.txtDokCep.Size = new System.Drawing.Size(116, 22);
            this.txtDokCep.TabIndex = 7;
            // 
            // txtDokDep1
            // 
            this.txtDokDep1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDokDep1.FormattingEnabled = true;
            this.txtDokDep1.Location = new System.Drawing.Point(124, 161);
            this.txtDokDep1.Name = "txtDokDep1";
            this.txtDokDep1.Size = new System.Drawing.Size(192, 24);
            this.txtDokDep1.TabIndex = 6;
            // 
            // pnlOrta
            // 
            this.pnlOrta.Controls.Add(this.txtDokTip);
            this.pnlOrta.Controls.Add(this.txtHKoduBul);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.txtMuaAdres);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtHastAdres);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.txtVnTc);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.txtVergiD);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtDokMail);
            this.pnlOrta.Controls.Add(this.txtDokTel);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtDokAdi);
            this.pnlOrta.Controls.Add(this.label10);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtDokUnvan);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtDokCep);
            this.pnlOrta.Controls.Add(this.txtDokDep1);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 86);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1520, 383);
            this.pnlOrta.TabIndex = 24;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.exit_64;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Location = new System.Drawing.Point(1425, 10);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 58);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.Sil64;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(262, 22);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(54, 46);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(196, 22);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(54, 46);
            this.btnSil.TabIndex = 0;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.Save_icon64x64;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.Location = new System.Drawing.Point(50, 22);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(54, 46);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 469);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1520, 28);
            this.splitter1.TabIndex = 23;
            this.splitter1.TabStop = false;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.CariKodu,
            this.CariAdi,
            this.CariTel,
            this.DoktorCep,
            this.CariMail});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 497);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1520, 184);
            this.Liste.TabIndex = 22;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // pnlAlt
            // 
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 681);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1520, 64);
            this.pnlAlt.TabIndex = 21;
            // 
            // lblDoktorKodu
            // 
            this.lblDoktorKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoktorKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorKodu.Location = new System.Drawing.Point(736, 45);
            this.lblDoktorKodu.Name = "lblDoktorKodu";
            this.lblDoktorKodu.Size = new System.Drawing.Size(171, 23);
            this.lblDoktorKodu.TabIndex = 1;
            this.lblDoktorKodu.Text = "***";
            this.lblDoktorKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject102_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(124, 22);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(54, 46);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblDoktorKodu);
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1520, 86);
            this.pnlUst.TabIndex = 20;
            // 
            // txtDokTip
            // 
            this.txtDokTip.FormattingEnabled = true;
            this.txtDokTip.Location = new System.Drawing.Point(123, 319);
            this.txtDokTip.Name = "txtDokTip";
            this.txtDokTip.Size = new System.Drawing.Size(193, 24);
            this.txtDokTip.TabIndex = 21;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.MinimumWidth = 6;
            this.Sira.Name = "Sira";
            this.Sira.Width = 62;
            // 
            // CariKodu
            // 
            this.CariKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariKodu.HeaderText = "Doktor Kodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 116;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Doktor Adi";
            this.CariAdi.MinimumWidth = 6;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Doktor Telefonu";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 139;
            // 
            // DoktorCep
            // 
            this.DoktorCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DoktorCep.HeaderText = "Doktor GSM";
            this.DoktorCep.MinimumWidth = 6;
            this.DoktorCep.Name = "DoktorCep";
            this.DoktorCep.Width = 114;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Doktor Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 108;
            // 
            // frmDoktorGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 745);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmDoktorGirisEkrani";
            this.Text = "frmDoktorGirisEkrani";
            this.Load += new System.EventHandler(this.frmDoktorGirisEkrani_Load);
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHKoduBul;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtMuaAdres;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtHastAdres;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox txtVnTc;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtVergiD;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDokMail;
        public System.Windows.Forms.MaskedTextBox txtDokTel;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDokAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox txtDokUnvan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MaskedTextBox txtDokCep;
        public System.Windows.Forms.ComboBox txtDokDep1;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlAlt;
        public System.Windows.Forms.Label lblDoktorKodu;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel pnlUst;
        public System.Windows.Forms.ComboBox txtDokTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
    }
}