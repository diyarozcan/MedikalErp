
namespace IEA_ErpProject102_Main.BilgiGirisİslemleri.Personeller
{
    partial class frmPersonelGirisEkrani
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtHKoduBul = new System.Windows.Forms.TextBox();
            this.txtPerAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerMail = new System.Windows.Forms.TextBox();
            this.txtPerTel = new System.Windows.Forms.MaskedTextBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerAdi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPerCep = new System.Windows.Forms.MaskedTextBox();
            this.txtPerDep1 = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.lblPerKodu = new System.Windows.Forms.Label();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtPerUnvan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVnTc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPerAdres2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPerTip = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.CheckBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariGiris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariCikis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOrta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
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
            // pnlOrta
            // 
            this.pnlOrta.Controls.Add(this.txtDurum);
            this.pnlOrta.Controls.Add(this.txtPerTip);
            this.pnlOrta.Controls.Add(this.label15);
            this.pnlOrta.Controls.Add(this.txtPerAdres2);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtVnTc);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtPerUnvan);
            this.pnlOrta.Controls.Add(this.txtBitisTarihi);
            this.pnlOrta.Controls.Add(this.txtGirisTarihi);
            this.pnlOrta.Controls.Add(this.txtHKoduBul);
            this.pnlOrta.Controls.Add(this.txtPerAdres);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtPerMail);
            this.pnlOrta.Controls.Add(this.txtPerTel);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.txtPerAdi);
            this.pnlOrta.Controls.Add(this.label10);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.label14);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtPerCep);
            this.pnlOrta.Controls.Add(this.txtPerDep1);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 86);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1520, 383);
            this.pnlOrta.TabIndex = 29;
            // 
            // txtBitisTarihi
            // 
            this.txtBitisTarihi.Location = new System.Drawing.Point(855, 228);
            this.txtBitisTarihi.Name = "txtBitisTarihi";
            this.txtBitisTarihi.Size = new System.Drawing.Size(228, 22);
            this.txtBitisTarihi.TabIndex = 21;
            // 
            // txtGirisTarihi
            // 
            this.txtGirisTarihi.Location = new System.Drawing.Point(855, 200);
            this.txtGirisTarihi.Name = "txtGirisTarihi";
            this.txtGirisTarihi.Size = new System.Drawing.Size(228, 22);
            this.txtGirisTarihi.TabIndex = 20;
            // 
            // txtHKoduBul
            // 
            this.txtHKoduBul.Location = new System.Drawing.Point(17, 12);
            this.txtHKoduBul.Name = "txtHKoduBul";
            this.txtHKoduBul.Size = new System.Drawing.Size(427, 22);
            this.txtHKoduBul.TabIndex = 19;
            // 
            // txtPerAdres
            // 
            this.txtPerAdres.Location = new System.Drawing.Point(855, 26);
            this.txtPerAdres.Multiline = true;
            this.txtPerAdres.Name = "txtPerAdres";
            this.txtPerAdres.Size = new System.Drawing.Size(317, 72);
            this.txtPerAdres.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Adi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(737, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cikis Tarihi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(759, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerMail
            // 
            this.txtPerMail.Location = new System.Drawing.Point(137, 200);
            this.txtPerMail.Name = "txtPerMail";
            this.txtPerMail.Size = new System.Drawing.Size(193, 22);
            this.txtPerMail.TabIndex = 14;
            // 
            // txtPerTel
            // 
            this.txtPerTel.Location = new System.Drawing.Point(137, 120);
            this.txtPerTel.Mask = "(999) 000-0000";
            this.txtPerTel.Name = "txtPerTel";
            this.txtPerTel.Size = new System.Drawing.Size(124, 22);
            this.txtPerTel.TabIndex = 13;
            // 
            // txtSehir
            // 
            this.txtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(138, 241);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(193, 24);
            this.txtSehir.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(737, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 61);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giris Tarihi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerAdi
            // 
            this.txtPerAdi.Location = new System.Drawing.Point(138, 86);
            this.txtPerAdi.Name = "txtPerAdi";
            this.txtPerAdi.Size = new System.Drawing.Size(317, 22);
            this.txtPerAdi.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(35, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Personel GSM";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(35, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Personel Tel : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(31, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Personel Mail : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(21, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "Sehir :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(26, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Departmani";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPerCep
            // 
            this.txtPerCep.Location = new System.Drawing.Point(137, 159);
            this.txtPerCep.Mask = "(999) 000-0000";
            this.txtPerCep.Name = "txtPerCep";
            this.txtPerCep.Size = new System.Drawing.Size(116, 22);
            this.txtPerCep.TabIndex = 7;
            // 
            // txtPerDep1
            // 
            this.txtPerDep1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPerDep1.FormattingEnabled = true;
            this.txtPerDep1.Location = new System.Drawing.Point(138, 270);
            this.txtPerDep1.Name = "txtPerDep1";
            this.txtPerDep1.Size = new System.Drawing.Size(192, 24);
            this.txtPerDep1.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 469);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1520, 28);
            this.splitter1.TabIndex = 28;
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
            this.PerCep,
            this.CariMail,
            this.CariGiris,
            this.CariCikis});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 497);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1520, 184);
            this.Liste.TabIndex = 27;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // pnlAlt
            // 
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 681);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1520, 64);
            this.pnlAlt.TabIndex = 26;
            // 
            // lblPerKodu
            // 
            this.lblPerKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPerKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPerKodu.Location = new System.Drawing.Point(736, 45);
            this.lblPerKodu.Name = "lblPerKodu";
            this.lblPerKodu.Size = new System.Drawing.Size(171, 23);
            this.lblPerKodu.TabIndex = 1;
            this.lblPerKodu.Text = "***";
            this.lblPerKodu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblPerKodu);
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1520, 86);
            this.pnlUst.TabIndex = 25;
            // 
            // txtPerUnvan
            // 
            this.txtPerUnvan.FormattingEnabled = true;
            this.txtPerUnvan.Location = new System.Drawing.Point(138, 46);
            this.txtPerUnvan.Name = "txtPerUnvan";
            this.txtPerUnvan.Size = new System.Drawing.Size(215, 24);
            this.txtPerUnvan.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Personel Unvani :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVnTc
            // 
            this.txtVnTc.Location = new System.Drawing.Point(133, 312);
            this.txtVnTc.Mask = "00000000000";
            this.txtVnTc.Name = "txtVnTc";
            this.txtVnTc.Size = new System.Drawing.Size(128, 22);
            this.txtVnTc.TabIndex = 25;
            this.txtVnTc.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(31, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tc No";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerAdres2
            // 
            this.txtPerAdres2.Location = new System.Drawing.Point(855, 109);
            this.txtPerAdres2.Multiline = true;
            this.txtPerAdres2.Name = "txtPerAdres2";
            this.txtPerAdres2.Size = new System.Drawing.Size(317, 72);
            this.txtPerAdres2.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(759, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 42);
            this.label8.TabIndex = 26;
            this.label8.Text = "Adres2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerTip
            // 
            this.txtPerTip.FormattingEnabled = true;
            this.txtPerTip.Location = new System.Drawing.Point(133, 348);
            this.txtPerTip.Name = "txtPerTip";
            this.txtPerTip.Size = new System.Drawing.Size(193, 24);
            this.txtPerTip.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(31, 348);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 28;
            this.label15.Text = "Personel Tipi :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDurum
            // 
            this.txtDurum.AutoSize = true;
            this.txtDurum.Location = new System.Drawing.Point(1126, 202);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(167, 21);
            this.txtDurum.TabIndex = 30;
            this.txtDurum.Text = "İs Bitis Tarihi Eklensin";
            this.txtDurum.UseVisualStyleBackColor = true;
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
            this.CariKodu.HeaderText = "Personel Kodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 130;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Personel Adi";
            this.CariAdi.MinimumWidth = 100;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Personel Telefonu";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 140;
            // 
            // PerCep
            // 
            this.PerCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PerCep.HeaderText = "Personel GSM";
            this.PerCep.MinimumWidth = 6;
            this.PerCep.Name = "PerCep";
            this.PerCep.Width = 118;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Personel Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 112;
            // 
            // CariGiris
            // 
            this.CariGiris.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = "-";
            this.CariGiris.DefaultCellStyle = dataGridViewCellStyle7;
            this.CariGiris.HeaderText = "Giris Tarihi";
            this.CariGiris.MinimumWidth = 6;
            this.CariGiris.Name = "CariGiris";
            this.CariGiris.Width = 98;
            // 
            // CariCikis
            // 
            this.CariCikis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = "-";
            this.CariCikis.DefaultCellStyle = dataGridViewCellStyle8;
            this.CariCikis.HeaderText = "Cikis Tarihi";
            this.CariCikis.MinimumWidth = 6;
            this.CariCikis.Name = "CariCikis";
            this.CariCikis.Width = 98;
            // 
            // frmPersonelGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 745);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmPersonelGirisEkrani";
            this.Text = "frmPersonelGirisEkrani";
            this.Load += new System.EventHandler(this.frmPersonelGirisEkrani_Load);
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.DateTimePicker txtBitisTarihi;
        private System.Windows.Forms.DateTimePicker txtGirisTarihi;
        private System.Windows.Forms.TextBox txtHKoduBul;
        public System.Windows.Forms.TextBox txtPerAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPerMail;
        public System.Windows.Forms.MaskedTextBox txtPerTel;
        public System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPerAdi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MaskedTextBox txtPerCep;
        public System.Windows.Forms.ComboBox txtPerDep1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlAlt;
        public System.Windows.Forms.Label lblPerKodu;
        private System.Windows.Forms.Panel pnlUst;
        public System.Windows.Forms.ComboBox txtPerUnvan;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPerAdres2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox txtVnTc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox txtDurum;
        public System.Windows.Forms.ComboBox txtPerTip;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariGiris;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariCikis;
    }
}