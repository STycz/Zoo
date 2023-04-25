namespace Zoo
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOpiekun = new System.Windows.Forms.TabPage();
            this.btnOpiekunZapisz = new System.Windows.Forms.Button();
            this.comboBoxPlec = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOpiekunNrTel = new System.Windows.Forms.TextBox();
            this.txtOpiekunWiek = new System.Windows.Forms.TextBox();
            this.txtOpiekunNazwisko = new System.Windows.Forms.TextBox();
            this.txtOpiekunImie = new System.Windows.Forms.TextBox();
            this.btnOpiekunEdytuj = new System.Windows.Forms.Button();
            this.btnOpiekunDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOpiekunowie = new System.Windows.Forms.DataGridView();
            this.tabMagazyn = new System.Windows.Forms.TabPage();
            this.dgvMagazynZawartosc = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvMagazyny = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabJedzenie = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxJedzenieMagID = new System.Windows.Forms.ComboBox();
            this.comboBoxJedzenieRodzaj = new System.Windows.Forms.ComboBox();
            this.txtJedzenieOpis = new System.Windows.Forms.TextBox();
            this.txtJedzenieNazwa = new System.Windows.Forms.TextBox();
            this.btnJedzenieZapisz = new System.Windows.Forms.Button();
            this.btnJedzenieUsun = new System.Windows.Forms.Button();
            this.btnJedzenieEdytuj = new System.Windows.Forms.Button();
            this.btnJedzenieDodaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvJedzenie = new System.Windows.Forms.DataGridView();
            this.tabSektor = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvSektorKlatki = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSektory = new System.Windows.Forms.DataGridView();
            this.tabKlatka = new System.Windows.Forms.TabPage();
            this.btnKlatkaZapisz = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxKlatkaOpiekun = new System.Windows.Forms.ComboBox();
            this.comboBoxKlatkaSektor = new System.Windows.Forms.ComboBox();
            this.txtKlatkaGlebokosc = new System.Windows.Forms.TextBox();
            this.txtKlatkaSzerokosc = new System.Windows.Forms.TextBox();
            this.txtKlatkaWysokosc = new System.Windows.Forms.TextBox();
            this.txtKlatkaNazwa = new System.Windows.Forms.TextBox();
            this.btnKlatkaEdytuj = new System.Windows.Forms.Button();
            this.btnKlatkaDodaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKlatki = new System.Windows.Forms.DataGridView();
            this.tabZwierze = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBoxZwierzeKlatka = new System.Windows.Forms.ComboBox();
            this.comboBoxZwierzePlec = new System.Windows.Forms.ComboBox();
            this.txtZwierzeDataPrzyjecia = new System.Windows.Forms.TextBox();
            this.txtZwierzeWiek = new System.Windows.Forms.TextBox();
            this.txtZwierzeNazwa = new System.Windows.Forms.TextBox();
            this.btnZwierzeZapisz = new System.Windows.Forms.Button();
            this.btnZwierzeEdytuj = new System.Windows.Forms.Button();
            this.btnZwierzeDodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvZwierzeta = new System.Windows.Forms.DataGridView();
            this.tabOpieka = new System.Windows.Forms.TabPage();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btnOpiekaZapisz = new System.Windows.Forms.Button();
            this.comboBoxOpiekaOpiekun = new System.Windows.Forms.ComboBox();
            this.comboBoxOpiekaZwierze = new System.Windows.Forms.ComboBox();
            this.txtOpiekaData = new System.Windows.Forms.TextBox();
            this.btnOpiekaEdytuj = new System.Windows.Forms.Button();
            this.btnOpiekaDodaj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvOpieki = new System.Windows.Forms.DataGridView();
            this.opiekunBS = new System.Windows.Forms.BindingSource(this.components);
            this.jedzenieBS = new System.Windows.Forms.BindingSource(this.components);
            this.magazynBS = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new Zoo.ZooDataSet();
            this.opiekunTA = new Zoo.ZooDataSetTableAdapters.OpiekunTableAdapter();
            this.jedzenieTA = new Zoo.ZooDataSetTableAdapters.JedzenieTableAdapter();
            this.magazynTA = new Zoo.ZooDataSetTableAdapters.MagazynTableAdapter();
            this.sektorTA = new Zoo.ZooDataSetTableAdapters.SektorTableAdapter();
            this.sektorBS = new System.Windows.Forms.BindingSource(this.components);
            this.klatkaTA = new Zoo.ZooDataSetTableAdapters.Klatka_zwierzeciaTableAdapter();
            this.klatkaBS = new System.Windows.Forms.BindingSource(this.components);
            this.zwierzeTA = new Zoo.ZooDataSetTableAdapters.ZwierzecieTableAdapter();
            this.zwierzeBS = new System.Windows.Forms.BindingSource(this.components);
            this.opiekaTA = new Zoo.ZooDataSetTableAdapters.OpiekaTableAdapter();
            this.opiekaBS = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxZwierzeGromada = new System.Windows.Forms.ComboBox();
            this.maskedTxtOpiekaRozpOpieki = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtOpiekaKonOpieki = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabOpiekun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpiekunowie)).BeginInit();
            this.tabMagazyn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynZawartosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazyny)).BeginInit();
            this.tabJedzenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedzenie)).BeginInit();
            this.tabSektor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektorKlatki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektory)).BeginInit();
            this.tabKlatka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlatki)).BeginInit();
            this.tabZwierze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZwierzeta)).BeginInit();
            this.tabOpieka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpieki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiekunBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedzenieBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klatkaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zwierzeBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiekaBS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOpiekun);
            this.tabControl1.Controls.Add(this.tabMagazyn);
            this.tabControl1.Controls.Add(this.tabJedzenie);
            this.tabControl1.Controls.Add(this.tabSektor);
            this.tabControl1.Controls.Add(this.tabKlatka);
            this.tabControl1.Controls.Add(this.tabZwierze);
            this.tabControl1.Controls.Add(this.tabOpieka);
            this.tabControl1.Location = new System.Drawing.Point(41, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1092, 693);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOpiekun
            // 
            this.tabOpiekun.Controls.Add(this.btnOpiekunZapisz);
            this.tabOpiekun.Controls.Add(this.comboBoxPlec);
            this.tabOpiekun.Controls.Add(this.label16);
            this.tabOpiekun.Controls.Add(this.label15);
            this.tabOpiekun.Controls.Add(this.label14);
            this.tabOpiekun.Controls.Add(this.label13);
            this.tabOpiekun.Controls.Add(this.label12);
            this.tabOpiekun.Controls.Add(this.txtOpiekunNrTel);
            this.tabOpiekun.Controls.Add(this.txtOpiekunWiek);
            this.tabOpiekun.Controls.Add(this.txtOpiekunNazwisko);
            this.tabOpiekun.Controls.Add(this.txtOpiekunImie);
            this.tabOpiekun.Controls.Add(this.btnOpiekunEdytuj);
            this.tabOpiekun.Controls.Add(this.btnOpiekunDodaj);
            this.tabOpiekun.Controls.Add(this.label4);
            this.tabOpiekun.Controls.Add(this.dgvOpiekunowie);
            this.tabOpiekun.Location = new System.Drawing.Point(4, 22);
            this.tabOpiekun.Name = "tabOpiekun";
            this.tabOpiekun.Size = new System.Drawing.Size(1084, 667);
            this.tabOpiekun.TabIndex = 2;
            this.tabOpiekun.Text = "Opiekun";
            this.tabOpiekun.UseVisualStyleBackColor = true;
            // 
            // btnOpiekunZapisz
            // 
            this.btnOpiekunZapisz.Enabled = false;
            this.btnOpiekunZapisz.Location = new System.Drawing.Point(253, 220);
            this.btnOpiekunZapisz.Name = "btnOpiekunZapisz";
            this.btnOpiekunZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnOpiekunZapisz.TabIndex = 24;
            this.btnOpiekunZapisz.Text = "Zapisz";
            this.btnOpiekunZapisz.UseVisualStyleBackColor = true;
            this.btnOpiekunZapisz.Click += new System.EventHandler(this.btnOpiekunZapisz_Click);
            // 
            // comboBoxPlec
            // 
            this.comboBoxPlec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlec.FormattingEnabled = true;
            this.comboBoxPlec.Items.AddRange(new object[] {
            "K",
            "M"});
            this.comboBoxPlec.Location = new System.Drawing.Point(92, 183);
            this.comboBoxPlec.Name = "comboBoxPlec";
            this.comboBoxPlec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlec.TabIndex = 23;
            this.comboBoxPlec.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlec_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Numer telefonu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Płeć";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Wiek";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Nazwisko";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Imię";
            // 
            // txtOpiekunNrTel
            // 
            this.txtOpiekunNrTel.Location = new System.Drawing.Point(92, 222);
            this.txtOpiekunNrTel.Name = "txtOpiekunNrTel";
            this.txtOpiekunNrTel.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunNrTel.TabIndex = 17;
            this.txtOpiekunNrTel.TextChanged += new System.EventHandler(this.txtOpiekunNrTel_TextChanged);
            this.txtOpiekunNrTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpiekunNrTel_KeyPress);
            // 
            // txtOpiekunWiek
            // 
            this.txtOpiekunWiek.Location = new System.Drawing.Point(92, 144);
            this.txtOpiekunWiek.Name = "txtOpiekunWiek";
            this.txtOpiekunWiek.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunWiek.TabIndex = 15;
            this.txtOpiekunWiek.TextChanged += new System.EventHandler(this.txtOpiekunWiek_TextChanged);
            this.txtOpiekunWiek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpiekunWiek_KeyPress);
            // 
            // txtOpiekunNazwisko
            // 
            this.txtOpiekunNazwisko.Location = new System.Drawing.Point(92, 105);
            this.txtOpiekunNazwisko.Name = "txtOpiekunNazwisko";
            this.txtOpiekunNazwisko.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunNazwisko.TabIndex = 14;
            this.txtOpiekunNazwisko.TextChanged += new System.EventHandler(this.txtOpiekunNazwisko_TextChanged);
            this.txtOpiekunNazwisko.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpiekunNazwisko_KeyPress);
            // 
            // txtOpiekunImie
            // 
            this.txtOpiekunImie.Location = new System.Drawing.Point(92, 66);
            this.txtOpiekunImie.Name = "txtOpiekunImie";
            this.txtOpiekunImie.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunImie.TabIndex = 13;
            this.txtOpiekunImie.TextChanged += new System.EventHandler(this.txtOpiekunImie_TextChanged_1);
            this.txtOpiekunImie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpiekunImie_KeyPress);
            // 
            // btnOpiekunEdytuj
            // 
            this.btnOpiekunEdytuj.Location = new System.Drawing.Point(253, 142);
            this.btnOpiekunEdytuj.Name = "btnOpiekunEdytuj";
            this.btnOpiekunEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnOpiekunEdytuj.TabIndex = 12;
            this.btnOpiekunEdytuj.Text = "Edytuj";
            this.btnOpiekunEdytuj.UseVisualStyleBackColor = true;
            this.btnOpiekunEdytuj.Click += new System.EventHandler(this.btnOpiekunEdytuj_Click);
            // 
            // btnOpiekunDodaj
            // 
            this.btnOpiekunDodaj.Location = new System.Drawing.Point(253, 64);
            this.btnOpiekunDodaj.Name = "btnOpiekunDodaj";
            this.btnOpiekunDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnOpiekunDodaj.TabIndex = 11;
            this.btnOpiekunDodaj.Text = "Dodaj";
            this.btnOpiekunDodaj.UseVisualStyleBackColor = true;
            this.btnOpiekunDodaj.Click += new System.EventHandler(this.btnOpiekunDodaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Opiekunowie";
            // 
            // dgvOpiekunowie
            // 
            this.dgvOpiekunowie.AllowUserToAddRows = false;
            this.dgvOpiekunowie.AllowUserToDeleteRows = false;
            this.dgvOpiekunowie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpiekunowie.Location = new System.Drawing.Point(351, 48);
            this.dgvOpiekunowie.MultiSelect = false;
            this.dgvOpiekunowie.Name = "dgvOpiekunowie";
            this.dgvOpiekunowie.ReadOnly = true;
            this.dgvOpiekunowie.RowHeadersVisible = false;
            this.dgvOpiekunowie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpiekunowie.Size = new System.Drawing.Size(694, 554);
            this.dgvOpiekunowie.TabIndex = 9;
            this.dgvOpiekunowie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpiekunowie_CellContentClick);
            // 
            // tabMagazyn
            // 
            this.tabMagazyn.Controls.Add(this.dgvMagazynZawartosc);
            this.tabMagazyn.Controls.Add(this.label8);
            this.tabMagazyn.Controls.Add(this.dgvMagazyny);
            this.tabMagazyn.Controls.Add(this.label1);
            this.tabMagazyn.Location = new System.Drawing.Point(4, 22);
            this.tabMagazyn.Name = "tabMagazyn";
            this.tabMagazyn.Padding = new System.Windows.Forms.Padding(3);
            this.tabMagazyn.Size = new System.Drawing.Size(1084, 667);
            this.tabMagazyn.TabIndex = 0;
            this.tabMagazyn.Text = "Magazyn";
            this.tabMagazyn.UseVisualStyleBackColor = true;
            // 
            // dgvMagazynZawartosc
            // 
            this.dgvMagazynZawartosc.AllowUserToAddRows = false;
            this.dgvMagazynZawartosc.AllowUserToDeleteRows = false;
            this.dgvMagazynZawartosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynZawartosc.Location = new System.Drawing.Point(323, 54);
            this.dgvMagazynZawartosc.Name = "dgvMagazynZawartosc";
            this.dgvMagazynZawartosc.ReadOnly = true;
            this.dgvMagazynZawartosc.RowHeadersVisible = false;
            this.dgvMagazynZawartosc.Size = new System.Drawing.Size(730, 536);
            this.dgvMagazynZawartosc.TabIndex = 11;
            this.dgvMagazynZawartosc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Magazyny";
            // 
            // dgvMagazyny
            // 
            this.dgvMagazyny.AllowUserToAddRows = false;
            this.dgvMagazyny.AllowUserToDeleteRows = false;
            this.dgvMagazyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazyny.ColumnHeadersVisible = false;
            this.dgvMagazyny.Location = new System.Drawing.Point(27, 54);
            this.dgvMagazyny.Name = "dgvMagazyny";
            this.dgvMagazyny.ReadOnly = true;
            this.dgvMagazyny.RowHeadersVisible = false;
            this.dgvMagazyny.Size = new System.Drawing.Size(263, 163);
            this.dgvMagazyny.TabIndex = 9;
            this.dgvMagazyny.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMagazyny_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zawartość magazynu";
            // 
            // tabJedzenie
            // 
            this.tabJedzenie.Controls.Add(this.label20);
            this.tabJedzenie.Controls.Add(this.label19);
            this.tabJedzenie.Controls.Add(this.label18);
            this.tabJedzenie.Controls.Add(this.label17);
            this.tabJedzenie.Controls.Add(this.comboBoxJedzenieMagID);
            this.tabJedzenie.Controls.Add(this.comboBoxJedzenieRodzaj);
            this.tabJedzenie.Controls.Add(this.txtJedzenieOpis);
            this.tabJedzenie.Controls.Add(this.txtJedzenieNazwa);
            this.tabJedzenie.Controls.Add(this.btnJedzenieZapisz);
            this.tabJedzenie.Controls.Add(this.btnJedzenieUsun);
            this.tabJedzenie.Controls.Add(this.btnJedzenieEdytuj);
            this.tabJedzenie.Controls.Add(this.btnJedzenieDodaj);
            this.tabJedzenie.Controls.Add(this.label2);
            this.tabJedzenie.Controls.Add(this.dgvJedzenie);
            this.tabJedzenie.Location = new System.Drawing.Point(4, 22);
            this.tabJedzenie.Name = "tabJedzenie";
            this.tabJedzenie.Size = new System.Drawing.Size(1084, 667);
            this.tabJedzenie.TabIndex = 6;
            this.tabJedzenie.Text = "Jedzenie";
            this.tabJedzenie.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(48, 289);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Magazyn";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(58, 237);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "Rodzaj";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(69, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Opis";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(58, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Nazwa";
            // 
            // comboBoxJedzenieMagID
            // 
            this.comboBoxJedzenieMagID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJedzenieMagID.FormattingEnabled = true;
            this.comboBoxJedzenieMagID.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxJedzenieMagID.Location = new System.Drawing.Point(104, 285);
            this.comboBoxJedzenieMagID.Name = "comboBoxJedzenieMagID";
            this.comboBoxJedzenieMagID.Size = new System.Drawing.Size(206, 21);
            this.comboBoxJedzenieMagID.TabIndex = 16;
            this.comboBoxJedzenieMagID.SelectedIndexChanged += new System.EventHandler(this.comboBoxJedzenieMagID_SelectedIndexChanged);
            // 
            // comboBoxJedzenieRodzaj
            // 
            this.comboBoxJedzenieRodzaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJedzenieRodzaj.FormattingEnabled = true;
            this.comboBoxJedzenieRodzaj.Items.AddRange(new object[] {
            "Mięso",
            "Rośliny",
            "Mieszanka"});
            this.comboBoxJedzenieRodzaj.Location = new System.Drawing.Point(104, 234);
            this.comboBoxJedzenieRodzaj.Name = "comboBoxJedzenieRodzaj";
            this.comboBoxJedzenieRodzaj.Size = new System.Drawing.Size(206, 21);
            this.comboBoxJedzenieRodzaj.TabIndex = 15;
            this.comboBoxJedzenieRodzaj.SelectedIndexChanged += new System.EventHandler(this.comboBoxJedzenieRodzaj_SelectedIndexChanged);
            // 
            // txtJedzenieOpis
            // 
            this.txtJedzenieOpis.Location = new System.Drawing.Point(104, 114);
            this.txtJedzenieOpis.Multiline = true;
            this.txtJedzenieOpis.Name = "txtJedzenieOpis";
            this.txtJedzenieOpis.Size = new System.Drawing.Size(206, 90);
            this.txtJedzenieOpis.TabIndex = 14;
            // 
            // txtJedzenieNazwa
            // 
            this.txtJedzenieNazwa.Location = new System.Drawing.Point(104, 64);
            this.txtJedzenieNazwa.Name = "txtJedzenieNazwa";
            this.txtJedzenieNazwa.Size = new System.Drawing.Size(206, 20);
            this.txtJedzenieNazwa.TabIndex = 13;
            this.txtJedzenieNazwa.TextChanged += new System.EventHandler(this.txtJedzenieNazwa_TextChanged);
            // 
            // btnJedzenieZapisz
            // 
            this.btnJedzenieZapisz.Enabled = false;
            this.btnJedzenieZapisz.Location = new System.Drawing.Point(334, 200);
            this.btnJedzenieZapisz.Name = "btnJedzenieZapisz";
            this.btnJedzenieZapisz.Size = new System.Drawing.Size(79, 34);
            this.btnJedzenieZapisz.TabIndex = 12;
            this.btnJedzenieZapisz.Text = "Zapisz";
            this.btnJedzenieZapisz.UseVisualStyleBackColor = true;
            this.btnJedzenieZapisz.Click += new System.EventHandler(this.btnJedzenieZapisz_Click);
            // 
            // btnJedzenieUsun
            // 
            this.btnJedzenieUsun.Location = new System.Drawing.Point(334, 272);
            this.btnJedzenieUsun.Name = "btnJedzenieUsun";
            this.btnJedzenieUsun.Size = new System.Drawing.Size(79, 34);
            this.btnJedzenieUsun.TabIndex = 11;
            this.btnJedzenieUsun.Text = "Usuń";
            this.btnJedzenieUsun.UseVisualStyleBackColor = true;
            this.btnJedzenieUsun.Click += new System.EventHandler(this.btnJedzenieUsun_Click);
            // 
            // btnJedzenieEdytuj
            // 
            this.btnJedzenieEdytuj.Location = new System.Drawing.Point(334, 128);
            this.btnJedzenieEdytuj.Name = "btnJedzenieEdytuj";
            this.btnJedzenieEdytuj.Size = new System.Drawing.Size(79, 34);
            this.btnJedzenieEdytuj.TabIndex = 10;
            this.btnJedzenieEdytuj.Text = "Edytuj";
            this.btnJedzenieEdytuj.UseVisualStyleBackColor = true;
            this.btnJedzenieEdytuj.Click += new System.EventHandler(this.btnJedzenieEdytuj_Click);
            // 
            // btnJedzenieDodaj
            // 
            this.btnJedzenieDodaj.Location = new System.Drawing.Point(334, 56);
            this.btnJedzenieDodaj.Name = "btnJedzenieDodaj";
            this.btnJedzenieDodaj.Size = new System.Drawing.Size(79, 34);
            this.btnJedzenieDodaj.TabIndex = 9;
            this.btnJedzenieDodaj.Text = "Dodaj";
            this.btnJedzenieDodaj.UseVisualStyleBackColor = true;
            this.btnJedzenieDodaj.Click += new System.EventHandler(this.btnJedzenieDodaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jedzenie";
            // 
            // dgvJedzenie
            // 
            this.dgvJedzenie.AllowUserToAddRows = false;
            this.dgvJedzenie.AllowUserToDeleteRows = false;
            this.dgvJedzenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJedzenie.Location = new System.Drawing.Point(449, 56);
            this.dgvJedzenie.Name = "dgvJedzenie";
            this.dgvJedzenie.ReadOnly = true;
            this.dgvJedzenie.RowHeadersVisible = false;
            this.dgvJedzenie.Size = new System.Drawing.Size(600, 565);
            this.dgvJedzenie.TabIndex = 0;
            // 
            // tabSektor
            // 
            this.tabSektor.Controls.Add(this.label9);
            this.tabSektor.Controls.Add(this.dgvSektorKlatki);
            this.tabSektor.Controls.Add(this.label3);
            this.tabSektor.Controls.Add(this.dgvSektory);
            this.tabSektor.Location = new System.Drawing.Point(4, 22);
            this.tabSektor.Name = "tabSektor";
            this.tabSektor.Padding = new System.Windows.Forms.Padding(3);
            this.tabSektor.Size = new System.Drawing.Size(1084, 667);
            this.tabSektor.TabIndex = 1;
            this.tabSektor.Text = "Sektor";
            this.tabSektor.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Klatki";
            // 
            // dgvSektorKlatki
            // 
            this.dgvSektorKlatki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSektorKlatki.Location = new System.Drawing.Point(346, 62);
            this.dgvSektorKlatki.Name = "dgvSektorKlatki";
            this.dgvSektorKlatki.RowHeadersVisible = false;
            this.dgvSektorKlatki.Size = new System.Drawing.Size(719, 554);
            this.dgvSektorKlatki.TabIndex = 11;
            this.dgvSektorKlatki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSektorKlatki_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sektory";
            // 
            // dgvSektory
            // 
            this.dgvSektory.AllowUserToAddRows = false;
            this.dgvSektory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSektory.Location = new System.Drawing.Point(18, 62);
            this.dgvSektory.Name = "dgvSektory";
            this.dgvSektory.RowHeadersVisible = false;
            this.dgvSektory.Size = new System.Drawing.Size(312, 554);
            this.dgvSektory.TabIndex = 9;
            this.dgvSektory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSektory_CellClick);
            // 
            // tabKlatka
            // 
            this.tabKlatka.Controls.Add(this.btnKlatkaZapisz);
            this.tabKlatka.Controls.Add(this.label24);
            this.tabKlatka.Controls.Add(this.label23);
            this.tabKlatka.Controls.Add(this.label22);
            this.tabKlatka.Controls.Add(this.label21);
            this.tabKlatka.Controls.Add(this.label11);
            this.tabKlatka.Controls.Add(this.label10);
            this.tabKlatka.Controls.Add(this.comboBoxKlatkaOpiekun);
            this.tabKlatka.Controls.Add(this.comboBoxKlatkaSektor);
            this.tabKlatka.Controls.Add(this.txtKlatkaGlebokosc);
            this.tabKlatka.Controls.Add(this.txtKlatkaSzerokosc);
            this.tabKlatka.Controls.Add(this.txtKlatkaWysokosc);
            this.tabKlatka.Controls.Add(this.txtKlatkaNazwa);
            this.tabKlatka.Controls.Add(this.btnKlatkaEdytuj);
            this.tabKlatka.Controls.Add(this.btnKlatkaDodaj);
            this.tabKlatka.Controls.Add(this.label5);
            this.tabKlatka.Controls.Add(this.dgvKlatki);
            this.tabKlatka.Location = new System.Drawing.Point(4, 22);
            this.tabKlatka.Name = "tabKlatka";
            this.tabKlatka.Size = new System.Drawing.Size(1084, 667);
            this.tabKlatka.TabIndex = 3;
            this.tabKlatka.Text = "Klatka";
            this.tabKlatka.UseVisualStyleBackColor = true;
            // 
            // btnKlatkaZapisz
            // 
            this.btnKlatkaZapisz.Enabled = false;
            this.btnKlatkaZapisz.Location = new System.Drawing.Point(227, 198);
            this.btnKlatkaZapisz.Name = "btnKlatkaZapisz";
            this.btnKlatkaZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnKlatkaZapisz.TabIndex = 25;
            this.btnKlatkaZapisz.Text = "Zapisz";
            this.btnKlatkaZapisz.UseVisualStyleBackColor = true;
            this.btnKlatkaZapisz.Click += new System.EventHandler(this.btnKlatkaZapisz_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(46, 201);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "Opiekun";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(55, 174);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "Sektor";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Głębokość";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(36, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Szerokość";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Wysokość";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nazwa";
            // 
            // comboBoxKlatkaOpiekun
            // 
            this.comboBoxKlatkaOpiekun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKlatkaOpiekun.FormattingEnabled = true;
            this.comboBoxKlatkaOpiekun.Location = new System.Drawing.Point(96, 198);
            this.comboBoxKlatkaOpiekun.Name = "comboBoxKlatkaOpiekun";
            this.comboBoxKlatkaOpiekun.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKlatkaOpiekun.TabIndex = 18;
            this.comboBoxKlatkaOpiekun.SelectedIndexChanged += new System.EventHandler(this.comboBoxKlatkaOpiekun_SelectedIndexChanged);
            // 
            // comboBoxKlatkaSektor
            // 
            this.comboBoxKlatkaSektor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKlatkaSektor.FormattingEnabled = true;
            this.comboBoxKlatkaSektor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxKlatkaSektor.Location = new System.Drawing.Point(96, 171);
            this.comboBoxKlatkaSektor.Name = "comboBoxKlatkaSektor";
            this.comboBoxKlatkaSektor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKlatkaSektor.TabIndex = 17;
            this.comboBoxKlatkaSektor.SelectedIndexChanged += new System.EventHandler(this.comboBoxKlatkaSektor_SelectedIndexChanged);
            // 
            // txtKlatkaGlebokosc
            // 
            this.txtKlatkaGlebokosc.Location = new System.Drawing.Point(96, 144);
            this.txtKlatkaGlebokosc.Name = "txtKlatkaGlebokosc";
            this.txtKlatkaGlebokosc.Size = new System.Drawing.Size(100, 20);
            this.txtKlatkaGlebokosc.TabIndex = 16;
            this.txtKlatkaGlebokosc.TextChanged += new System.EventHandler(this.txtKlatkaGlebokosc_TextChanged);
            this.txtKlatkaGlebokosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKlatkaGlebokosc_KeyPress);
            // 
            // txtKlatkaSzerokosc
            // 
            this.txtKlatkaSzerokosc.Location = new System.Drawing.Point(96, 118);
            this.txtKlatkaSzerokosc.Name = "txtKlatkaSzerokosc";
            this.txtKlatkaSzerokosc.Size = new System.Drawing.Size(100, 20);
            this.txtKlatkaSzerokosc.TabIndex = 15;
            this.txtKlatkaSzerokosc.TextChanged += new System.EventHandler(this.txtKlatkaSzerokosc_TextChanged);
            this.txtKlatkaSzerokosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKlatkaSzerokosc_KeyPress);
            // 
            // txtKlatkaWysokosc
            // 
            this.txtKlatkaWysokosc.Location = new System.Drawing.Point(96, 92);
            this.txtKlatkaWysokosc.Name = "txtKlatkaWysokosc";
            this.txtKlatkaWysokosc.Size = new System.Drawing.Size(100, 20);
            this.txtKlatkaWysokosc.TabIndex = 14;
            this.txtKlatkaWysokosc.TextChanged += new System.EventHandler(this.txtKlatkaWysokosc_TextChanged);
            this.txtKlatkaWysokosc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKlatkaWysokosc_KeyPress);
            // 
            // txtKlatkaNazwa
            // 
            this.txtKlatkaNazwa.Location = new System.Drawing.Point(96, 66);
            this.txtKlatkaNazwa.Name = "txtKlatkaNazwa";
            this.txtKlatkaNazwa.Size = new System.Drawing.Size(100, 20);
            this.txtKlatkaNazwa.TabIndex = 13;
            this.txtKlatkaNazwa.TextChanged += new System.EventHandler(this.txtKlatkaNazwa_TextChanged);
            this.txtKlatkaNazwa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKlatkaNazwa_KeyPress);
            // 
            // btnKlatkaEdytuj
            // 
            this.btnKlatkaEdytuj.Location = new System.Drawing.Point(227, 132);
            this.btnKlatkaEdytuj.Name = "btnKlatkaEdytuj";
            this.btnKlatkaEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnKlatkaEdytuj.TabIndex = 12;
            this.btnKlatkaEdytuj.Text = "Edytuj";
            this.btnKlatkaEdytuj.UseVisualStyleBackColor = true;
            this.btnKlatkaEdytuj.Click += new System.EventHandler(this.btnKlatkaEdytuj_Click);
            // 
            // btnKlatkaDodaj
            // 
            this.btnKlatkaDodaj.Location = new System.Drawing.Point(227, 66);
            this.btnKlatkaDodaj.Name = "btnKlatkaDodaj";
            this.btnKlatkaDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnKlatkaDodaj.TabIndex = 11;
            this.btnKlatkaDodaj.Text = "Dodaj";
            this.btnKlatkaDodaj.UseVisualStyleBackColor = true;
            this.btnKlatkaDodaj.Click += new System.EventHandler(this.btnKlatkaDodaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Klatki";
            // 
            // dgvKlatki
            // 
            this.dgvKlatki.AllowUserToAddRows = false;
            this.dgvKlatki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlatki.Location = new System.Drawing.Point(334, 64);
            this.dgvKlatki.Name = "dgvKlatki";
            this.dgvKlatki.RowHeadersVisible = false;
            this.dgvKlatki.Size = new System.Drawing.Size(718, 554);
            this.dgvKlatki.TabIndex = 9;
            // 
            // tabZwierze
            // 
            this.tabZwierze.Controls.Add(this.comboBoxZwierzeGromada);
            this.tabZwierze.Controls.Add(this.label30);
            this.tabZwierze.Controls.Add(this.label29);
            this.tabZwierze.Controls.Add(this.label28);
            this.tabZwierze.Controls.Add(this.label27);
            this.tabZwierze.Controls.Add(this.label26);
            this.tabZwierze.Controls.Add(this.label25);
            this.tabZwierze.Controls.Add(this.comboBoxZwierzeKlatka);
            this.tabZwierze.Controls.Add(this.comboBoxZwierzePlec);
            this.tabZwierze.Controls.Add(this.txtZwierzeDataPrzyjecia);
            this.tabZwierze.Controls.Add(this.txtZwierzeWiek);
            this.tabZwierze.Controls.Add(this.txtZwierzeNazwa);
            this.tabZwierze.Controls.Add(this.btnZwierzeZapisz);
            this.tabZwierze.Controls.Add(this.btnZwierzeEdytuj);
            this.tabZwierze.Controls.Add(this.btnZwierzeDodaj);
            this.tabZwierze.Controls.Add(this.label6);
            this.tabZwierze.Controls.Add(this.dgvZwierzeta);
            this.tabZwierze.Location = new System.Drawing.Point(4, 22);
            this.tabZwierze.Name = "tabZwierze";
            this.tabZwierze.Size = new System.Drawing.Size(1084, 667);
            this.tabZwierze.TabIndex = 4;
            this.tabZwierze.Text = "Zwierzę";
            this.tabZwierze.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(41, 189);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(37, 13);
            this.label30.TabIndex = 25;
            this.label30.Text = "Klatka";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(4, 163);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 13);
            this.label29.TabIndex = 24;
            this.label29.Text = "Data przyjęcia";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(48, 136);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(30, 13);
            this.label28.TabIndex = 23;
            this.label28.Text = "Płeć";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(30, 110);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 13);
            this.label27.TabIndex = 22;
            this.label27.Text = "Gromada";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(46, 84);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 13);
            this.label26.TabIndex = 21;
            this.label26.Text = "Wiek";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(38, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "Nazwa";
            // 
            // comboBoxZwierzeKlatka
            // 
            this.comboBoxZwierzeKlatka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZwierzeKlatka.FormattingEnabled = true;
            this.comboBoxZwierzeKlatka.Location = new System.Drawing.Point(84, 186);
            this.comboBoxZwierzeKlatka.Name = "comboBoxZwierzeKlatka";
            this.comboBoxZwierzeKlatka.Size = new System.Drawing.Size(164, 21);
            this.comboBoxZwierzeKlatka.TabIndex = 19;
            this.comboBoxZwierzeKlatka.SelectedIndexChanged += new System.EventHandler(this.comboBoxZwierzeKlatka_SelectedIndexChanged);
            // 
            // comboBoxZwierzePlec
            // 
            this.comboBoxZwierzePlec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZwierzePlec.FormattingEnabled = true;
            this.comboBoxZwierzePlec.Items.AddRange(new object[] {
            "K",
            "M"});
            this.comboBoxZwierzePlec.Location = new System.Drawing.Point(84, 133);
            this.comboBoxZwierzePlec.Name = "comboBoxZwierzePlec";
            this.comboBoxZwierzePlec.Size = new System.Drawing.Size(164, 21);
            this.comboBoxZwierzePlec.TabIndex = 18;
            this.comboBoxZwierzePlec.SelectedIndexChanged += new System.EventHandler(this.comboBoxZwierzePlec_SelectedIndexChanged);
            // 
            // txtZwierzeDataPrzyjecia
            // 
            this.txtZwierzeDataPrzyjecia.Location = new System.Drawing.Point(84, 160);
            this.txtZwierzeDataPrzyjecia.Name = "txtZwierzeDataPrzyjecia";
            this.txtZwierzeDataPrzyjecia.Size = new System.Drawing.Size(164, 20);
            this.txtZwierzeDataPrzyjecia.TabIndex = 17;
            this.txtZwierzeDataPrzyjecia.TextChanged += new System.EventHandler(this.txtZwierzeDataPrzyjecia_TextChanged);
            // 
            // txtZwierzeWiek
            // 
            this.txtZwierzeWiek.Location = new System.Drawing.Point(84, 81);
            this.txtZwierzeWiek.Name = "txtZwierzeWiek";
            this.txtZwierzeWiek.Size = new System.Drawing.Size(164, 20);
            this.txtZwierzeWiek.TabIndex = 15;
            this.txtZwierzeWiek.TextChanged += new System.EventHandler(this.txtZwierzeWiek_TextChanged);
            this.txtZwierzeWiek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZwierzeWiek_KeyPress);
            // 
            // txtZwierzeNazwa
            // 
            this.txtZwierzeNazwa.Location = new System.Drawing.Point(84, 55);
            this.txtZwierzeNazwa.Name = "txtZwierzeNazwa";
            this.txtZwierzeNazwa.Size = new System.Drawing.Size(164, 20);
            this.txtZwierzeNazwa.TabIndex = 14;
            this.txtZwierzeNazwa.TextChanged += new System.EventHandler(this.txtZwierzeNazwa_TextChanged);
            // 
            // btnZwierzeZapisz
            // 
            this.btnZwierzeZapisz.Location = new System.Drawing.Point(265, 183);
            this.btnZwierzeZapisz.Name = "btnZwierzeZapisz";
            this.btnZwierzeZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZwierzeZapisz.TabIndex = 13;
            this.btnZwierzeZapisz.Text = "Zapisz";
            this.btnZwierzeZapisz.UseVisualStyleBackColor = true;
            this.btnZwierzeZapisz.Click += new System.EventHandler(this.btnZwierzeZapisz_Click);
            // 
            // btnZwierzeEdytuj
            // 
            this.btnZwierzeEdytuj.Location = new System.Drawing.Point(265, 119);
            this.btnZwierzeEdytuj.Name = "btnZwierzeEdytuj";
            this.btnZwierzeEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnZwierzeEdytuj.TabIndex = 12;
            this.btnZwierzeEdytuj.Text = "Edytuj";
            this.btnZwierzeEdytuj.UseVisualStyleBackColor = true;
            this.btnZwierzeEdytuj.Click += new System.EventHandler(this.btnZwierzeEdytuj_Click);
            // 
            // btnZwierzeDodaj
            // 
            this.btnZwierzeDodaj.Location = new System.Drawing.Point(265, 55);
            this.btnZwierzeDodaj.Name = "btnZwierzeDodaj";
            this.btnZwierzeDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnZwierzeDodaj.TabIndex = 11;
            this.btnZwierzeDodaj.Text = "Dodaj";
            this.btnZwierzeDodaj.UseVisualStyleBackColor = true;
            this.btnZwierzeDodaj.Click += new System.EventHandler(this.btnZwierzeDodaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zwierzęta";
            // 
            // dgvZwierzeta
            // 
            this.dgvZwierzeta.AllowUserToAddRows = false;
            this.dgvZwierzeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZwierzeta.Location = new System.Drawing.Point(357, 55);
            this.dgvZwierzeta.Name = "dgvZwierzeta";
            this.dgvZwierzeta.RowHeadersVisible = false;
            this.dgvZwierzeta.Size = new System.Drawing.Size(714, 554);
            this.dgvZwierzeta.TabIndex = 9;
            // 
            // tabOpieka
            // 
            this.tabOpieka.Controls.Add(this.maskedTxtOpiekaKonOpieki);
            this.tabOpieka.Controls.Add(this.maskedTxtOpiekaRozpOpieki);
            this.tabOpieka.Controls.Add(this.label35);
            this.tabOpieka.Controls.Add(this.label34);
            this.tabOpieka.Controls.Add(this.label33);
            this.tabOpieka.Controls.Add(this.label32);
            this.tabOpieka.Controls.Add(this.label31);
            this.tabOpieka.Controls.Add(this.btnOpiekaZapisz);
            this.tabOpieka.Controls.Add(this.comboBoxOpiekaOpiekun);
            this.tabOpieka.Controls.Add(this.comboBoxOpiekaZwierze);
            this.tabOpieka.Controls.Add(this.txtOpiekaData);
            this.tabOpieka.Controls.Add(this.btnOpiekaEdytuj);
            this.tabOpieka.Controls.Add(this.btnOpiekaDodaj);
            this.tabOpieka.Controls.Add(this.label7);
            this.tabOpieka.Controls.Add(this.dgvOpieki);
            this.tabOpieka.Location = new System.Drawing.Point(4, 22);
            this.tabOpieka.Name = "tabOpieka";
            this.tabOpieka.Size = new System.Drawing.Size(1084, 667);
            this.tabOpieka.TabIndex = 5;
            this.tabOpieka.Text = "Opieka";
            this.tabOpieka.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(62, 219);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(47, 13);
            this.label35.TabIndex = 23;
            this.label35.Text = "Opiekun";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(65, 181);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(44, 13);
            this.label34.TabIndex = 22;
            this.label34.Text = "Zwierzę";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(79, 144);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(30, 13);
            this.label33.TabIndex = 21;
            this.label33.Text = "Data";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(38, 107);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(71, 13);
            this.label32.TabIndex = 20;
            this.label32.Text = "Koniec opieki";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 69);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 13);
            this.label31.TabIndex = 19;
            this.label31.Text = "Rozpoczęcie opieki";
            // 
            // btnOpiekaZapisz
            // 
            this.btnOpiekaZapisz.Enabled = false;
            this.btnOpiekaZapisz.Location = new System.Drawing.Point(253, 214);
            this.btnOpiekaZapisz.Name = "btnOpiekaZapisz";
            this.btnOpiekaZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnOpiekaZapisz.TabIndex = 18;
            this.btnOpiekaZapisz.Text = "Zapisz";
            this.btnOpiekaZapisz.UseVisualStyleBackColor = true;
            this.btnOpiekaZapisz.Click += new System.EventHandler(this.btnOpiekaZapisz_Click);
            // 
            // comboBoxOpiekaOpiekun
            // 
            this.comboBoxOpiekaOpiekun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpiekaOpiekun.FormattingEnabled = true;
            this.comboBoxOpiekaOpiekun.Location = new System.Drawing.Point(115, 216);
            this.comboBoxOpiekaOpiekun.Name = "comboBoxOpiekaOpiekun";
            this.comboBoxOpiekaOpiekun.Size = new System.Drawing.Size(100, 21);
            this.comboBoxOpiekaOpiekun.TabIndex = 17;
            this.comboBoxOpiekaOpiekun.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpiekaOpiekun_SelectedIndexChanged);
            // 
            // comboBoxOpiekaZwierze
            // 
            this.comboBoxOpiekaZwierze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpiekaZwierze.FormattingEnabled = true;
            this.comboBoxOpiekaZwierze.Location = new System.Drawing.Point(115, 178);
            this.comboBoxOpiekaZwierze.Name = "comboBoxOpiekaZwierze";
            this.comboBoxOpiekaZwierze.Size = new System.Drawing.Size(100, 21);
            this.comboBoxOpiekaZwierze.TabIndex = 16;
            this.comboBoxOpiekaZwierze.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpiekaZwierze_SelectedIndexChanged);
            // 
            // txtOpiekaData
            // 
            this.txtOpiekaData.Location = new System.Drawing.Point(115, 141);
            this.txtOpiekaData.Name = "txtOpiekaData";
            this.txtOpiekaData.Size = new System.Drawing.Size(100, 20);
            this.txtOpiekaData.TabIndex = 15;
            this.txtOpiekaData.TextChanged += new System.EventHandler(this.txtOpiekaData_TextChanged);
            // 
            // btnOpiekaEdytuj
            // 
            this.btnOpiekaEdytuj.Location = new System.Drawing.Point(253, 139);
            this.btnOpiekaEdytuj.Name = "btnOpiekaEdytuj";
            this.btnOpiekaEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnOpiekaEdytuj.TabIndex = 12;
            this.btnOpiekaEdytuj.Text = "Edytuj";
            this.btnOpiekaEdytuj.UseVisualStyleBackColor = true;
            this.btnOpiekaEdytuj.Click += new System.EventHandler(this.btnOpiekaEdytuj_Click);
            // 
            // btnOpiekaDodaj
            // 
            this.btnOpiekaDodaj.Location = new System.Drawing.Point(253, 64);
            this.btnOpiekaDodaj.Name = "btnOpiekaDodaj";
            this.btnOpiekaDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnOpiekaDodaj.TabIndex = 11;
            this.btnOpiekaDodaj.Text = "Dodaj";
            this.btnOpiekaDodaj.UseVisualStyleBackColor = true;
            this.btnOpiekaDodaj.Click += new System.EventHandler(this.btnOpiekaDodaj_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Odbyte opieki";
            // 
            // dgvOpieki
            // 
            this.dgvOpieki.AllowUserToAddRows = false;
            this.dgvOpieki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpieki.Location = new System.Drawing.Point(375, 64);
            this.dgvOpieki.Name = "dgvOpieki";
            this.dgvOpieki.RowHeadersVisible = false;
            this.dgvOpieki.Size = new System.Drawing.Size(690, 554);
            this.dgvOpieki.TabIndex = 9;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "ZooDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opiekunTA
            // 
            this.opiekunTA.ClearBeforeFill = true;
            // 
            // jedzenieTA
            // 
            this.jedzenieTA.ClearBeforeFill = true;
            // 
            // magazynTA
            // 
            this.magazynTA.ClearBeforeFill = true;
            // 
            // sektorTA
            // 
            this.sektorTA.ClearBeforeFill = true;
            // 
            // klatkaTA
            // 
            this.klatkaTA.ClearBeforeFill = true;
            // 
            // zwierzeTA
            // 
            this.zwierzeTA.ClearBeforeFill = true;
            // 
            // opiekaTA
            // 
            this.opiekaTA.ClearBeforeFill = true;
            // 
            // comboBoxZwierzeGromada
            // 
            this.comboBoxZwierzeGromada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZwierzeGromada.FormattingEnabled = true;
            this.comboBoxZwierzeGromada.Items.AddRange(new object[] {
            "Ssak",
            "Gad",
            "Płaz",
            "Ptak",
            "Ryba"});
            this.comboBoxZwierzeGromada.Location = new System.Drawing.Point(84, 107);
            this.comboBoxZwierzeGromada.Name = "comboBoxZwierzeGromada";
            this.comboBoxZwierzeGromada.Size = new System.Drawing.Size(164, 21);
            this.comboBoxZwierzeGromada.TabIndex = 26;
            this.comboBoxZwierzeGromada.SelectedIndexChanged += new System.EventHandler(this.comboBoxZwierzeGromada_SelectedIndexChanged);
            // 
            // maskedTxtOpiekaRozpOpieki
            // 
            this.maskedTxtOpiekaRozpOpieki.Location = new System.Drawing.Point(115, 66);
            this.maskedTxtOpiekaRozpOpieki.Mask = "00:00";
            this.maskedTxtOpiekaRozpOpieki.Name = "maskedTxtOpiekaRozpOpieki";
            this.maskedTxtOpiekaRozpOpieki.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtOpiekaRozpOpieki.TabIndex = 24;
            this.maskedTxtOpiekaRozpOpieki.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtOpiekaRozpOpieki_MaskInputRejected);
            this.maskedTxtOpiekaRozpOpieki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTxtOpiekaRozpOpieki_KeyPress);
            // 
            // maskedTxtOpiekaKonOpieki
            // 
            this.maskedTxtOpiekaKonOpieki.Location = new System.Drawing.Point(115, 104);
            this.maskedTxtOpiekaKonOpieki.Mask = "00:00";
            this.maskedTxtOpiekaKonOpieki.Name = "maskedTxtOpiekaKonOpieki";
            this.maskedTxtOpiekaKonOpieki.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtOpiekaKonOpieki.TabIndex = 25;
            this.maskedTxtOpiekaKonOpieki.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTxtOpiekaKonOpieki_MaskInputRejected);
            this.maskedTxtOpiekaKonOpieki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTxtOpiekaKonOpieki_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 788);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabOpiekun.ResumeLayout(false);
            this.tabOpiekun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpiekunowie)).EndInit();
            this.tabMagazyn.ResumeLayout(false);
            this.tabMagazyn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynZawartosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazyny)).EndInit();
            this.tabJedzenie.ResumeLayout(false);
            this.tabJedzenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedzenie)).EndInit();
            this.tabSektor.ResumeLayout(false);
            this.tabSektor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektorKlatki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektory)).EndInit();
            this.tabKlatka.ResumeLayout(false);
            this.tabKlatka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlatki)).EndInit();
            this.tabZwierze.ResumeLayout(false);
            this.tabZwierze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZwierzeta)).EndInit();
            this.tabOpieka.ResumeLayout(false);
            this.tabOpieka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpieki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiekunBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedzenieBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klatkaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zwierzeBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiekaBS)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabJedzenie;
		private System.Windows.Forms.Button btnJedzenieZapisz;
		private System.Windows.Forms.Button btnJedzenieUsun;
		private System.Windows.Forms.Button btnJedzenieEdytuj;
		private System.Windows.Forms.Button btnJedzenieDodaj;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvJedzenie;
		private System.Windows.Forms.TabPage tabMagazyn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dgvMagazyny;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabSektor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView dgvSektorKlatki;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvSektory;
		private System.Windows.Forms.TabPage tabOpiekun;
		private System.Windows.Forms.Button btnOpiekunEdytuj;
		private System.Windows.Forms.Button btnOpiekunDodaj;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvOpiekunowie;
		private System.Windows.Forms.TabPage tabKlatka;
		private System.Windows.Forms.Button btnKlatkaEdytuj;
		private System.Windows.Forms.Button btnKlatkaDodaj;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgvKlatki;
		private System.Windows.Forms.TabPage tabZwierze;
		private System.Windows.Forms.Button btnZwierzeEdytuj;
		private System.Windows.Forms.Button btnZwierzeDodaj;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvZwierzeta;
		private System.Windows.Forms.TabPage tabOpieka;
		private System.Windows.Forms.Button btnOpiekaEdytuj;
		private System.Windows.Forms.Button btnOpiekaDodaj;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgvOpieki;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOpiekunNrTel;
        private System.Windows.Forms.TextBox txtOpiekunWiek;
        private System.Windows.Forms.TextBox txtOpiekunNazwisko;
        private System.Windows.Forms.TextBox txtOpiekunImie;
        private System.Windows.Forms.ComboBox comboBoxPlec;
        private System.Windows.Forms.Button btnOpiekunZapisz;
        private ZooDataSet mainDataSet;
        private ZooDataSetTableAdapters.OpiekunTableAdapter opiekunTA;
        private System.Windows.Forms.BindingSource opiekunBS;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxJedzenieMagID;
        private System.Windows.Forms.ComboBox comboBoxJedzenieRodzaj;
        private System.Windows.Forms.TextBox txtJedzenieOpis;
        private System.Windows.Forms.TextBox txtJedzenieNazwa;
        private ZooDataSetTableAdapters.JedzenieTableAdapter jedzenieTA;
        private System.Windows.Forms.BindingSource jedzenieBS;
        private ZooDataSetTableAdapters.MagazynTableAdapter magazynTA;
        private System.Windows.Forms.BindingSource magazynBS;
        private System.Windows.Forms.DataGridView dgvMagazynZawartosc;
        private ZooDataSetTableAdapters.SektorTableAdapter sektorTA;
        private System.Windows.Forms.BindingSource sektorBS;
        private System.Windows.Forms.TextBox txtKlatkaGlebokosc;
        private System.Windows.Forms.TextBox txtKlatkaSzerokosc;
        private System.Windows.Forms.TextBox txtKlatkaWysokosc;
        private System.Windows.Forms.TextBox txtKlatkaNazwa;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxKlatkaOpiekun;
        private System.Windows.Forms.ComboBox comboBoxKlatkaSektor;
        private System.Windows.Forms.Button btnKlatkaZapisz;
        private ZooDataSetTableAdapters.Klatka_zwierzeciaTableAdapter klatkaTA;
        private System.Windows.Forms.BindingSource klatkaBS;
        private System.Windows.Forms.Button btnZwierzeZapisz;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBoxZwierzeKlatka;
        private System.Windows.Forms.ComboBox comboBoxZwierzePlec;
        private System.Windows.Forms.TextBox txtZwierzeDataPrzyjecia;
        private System.Windows.Forms.TextBox txtZwierzeWiek;
        private System.Windows.Forms.TextBox txtZwierzeNazwa;
        private ZooDataSetTableAdapters.ZwierzecieTableAdapter zwierzeTA;
        private System.Windows.Forms.BindingSource zwierzeBS;
        private System.Windows.Forms.Button btnOpiekaZapisz;
        private System.Windows.Forms.ComboBox comboBoxOpiekaOpiekun;
        private System.Windows.Forms.ComboBox comboBoxOpiekaZwierze;
        private System.Windows.Forms.TextBox txtOpiekaData;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private ZooDataSetTableAdapters.OpiekaTableAdapter opiekaTA;
        private System.Windows.Forms.BindingSource opiekaBS;
        private System.Windows.Forms.ComboBox comboBoxZwierzeGromada;
        private System.Windows.Forms.MaskedTextBox maskedTxtOpiekaRozpOpieki;
        private System.Windows.Forms.MaskedTextBox maskedTxtOpiekaKonOpieki;
    }
}

