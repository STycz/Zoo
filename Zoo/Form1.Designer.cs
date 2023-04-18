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
            this.tabMagazyn = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvMagazyny = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSektory = new System.Windows.Forms.DataGridView();
            this.tabKlatka = new System.Windows.Forms.TabPage();
            this.btnKlatkaEdytuj = new System.Windows.Forms.Button();
            this.btnKlatkaDodaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabZwierze = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabOpieka = new System.Windows.Forms.TabPage();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.opiekunBS = new System.Windows.Forms.BindingSource(this.components);
            this.jedzenieBS = new System.Windows.Forms.BindingSource(this.components);
            this.magazynBS = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new Zoo.ZooDataSet();
            this.opiekunTA = new Zoo.ZooDataSetTableAdapters.OpiekunTableAdapter();
            this.jedzenieTA = new Zoo.ZooDataSetTableAdapters.JedzenieTableAdapter();
            this.magazynTA = new Zoo.ZooDataSetTableAdapters.MagazynTableAdapter();
            this.dgvMagazynZawartosc = new System.Windows.Forms.DataGridView();
            this.sektorTA = new Zoo.ZooDataSetTableAdapters.SektorTableAdapter();
            this.sektorBS = new System.Windows.Forms.BindingSource(this.components);
            this.txtKlatkaNazwa = new System.Windows.Forms.TextBox();
            this.txtKlatkaWysokosc = new System.Windows.Forms.TextBox();
            this.txtKlatkaSzerokosc = new System.Windows.Forms.TextBox();
            this.txtKlatkaGlebokosc = new System.Windows.Forms.TextBox();
            this.comboBoxKlatkaSektor = new System.Windows.Forms.ComboBox();
            this.comboBoxKlatkaOpiekun = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnKlatkaZapisz = new System.Windows.Forms.Button();
            this.klatkaTA = new Zoo.ZooDataSetTableAdapters.Klatka_zwierzeciaTableAdapter();
            this.klatkaBS = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabMagazyn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazyny)).BeginInit();
            this.tabOpiekun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpiekunowie)).BeginInit();
            this.tabJedzenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedzenie)).BeginInit();
            this.tabSektor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektory)).BeginInit();
            this.tabKlatka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabZwierze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabOpieka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiekunBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedzenieBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynZawartosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klatkaBS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMagazyn);
            this.tabControl1.Controls.Add(this.tabOpiekun);
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
            this.label1.Location = new System.Drawing.Point(576, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zawartość magazynu";
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
            this.comboBoxPlec.FormattingEnabled = true;
            this.comboBoxPlec.Items.AddRange(new object[] {
            "K",
            "M"});
            this.comboBoxPlec.Location = new System.Drawing.Point(92, 183);
            this.comboBoxPlec.Name = "comboBoxPlec";
            this.comboBoxPlec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlec.TabIndex = 23;
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
            // 
            // txtOpiekunWiek
            // 
            this.txtOpiekunWiek.Location = new System.Drawing.Point(92, 144);
            this.txtOpiekunWiek.Name = "txtOpiekunWiek";
            this.txtOpiekunWiek.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunWiek.TabIndex = 15;
            // 
            // txtOpiekunNazwisko
            // 
            this.txtOpiekunNazwisko.Location = new System.Drawing.Point(92, 105);
            this.txtOpiekunNazwisko.Name = "txtOpiekunNazwisko";
            this.txtOpiekunNazwisko.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunNazwisko.TabIndex = 14;
            // 
            // txtOpiekunImie
            // 
            this.txtOpiekunImie.Location = new System.Drawing.Point(92, 66);
            this.txtOpiekunImie.Name = "txtOpiekunImie";
            this.txtOpiekunImie.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunImie.TabIndex = 13;
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
            this.label4.Location = new System.Drawing.Point(521, 32);
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
            this.dgvOpiekunowie.Location = new System.Drawing.Point(524, 48);
            this.dgvOpiekunowie.MultiSelect = false;
            this.dgvOpiekunowie.Name = "dgvOpiekunowie";
            this.dgvOpiekunowie.ReadOnly = true;
            this.dgvOpiekunowie.RowHeadersVisible = false;
            this.dgvOpiekunowie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOpiekunowie.Size = new System.Drawing.Size(457, 554);
            this.dgvOpiekunowie.TabIndex = 9;
            this.dgvOpiekunowie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOpiekunowie_CellContentClick);
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
            this.comboBoxJedzenieMagID.FormattingEnabled = true;
            this.comboBoxJedzenieMagID.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxJedzenieMagID.Location = new System.Drawing.Point(104, 285);
            this.comboBoxJedzenieMagID.Name = "comboBoxJedzenieMagID";
            this.comboBoxJedzenieMagID.Size = new System.Drawing.Size(206, 21);
            this.comboBoxJedzenieMagID.TabIndex = 16;
            // 
            // comboBoxJedzenieRodzaj
            // 
            this.comboBoxJedzenieRodzaj.FormattingEnabled = true;
            this.comboBoxJedzenieRodzaj.Items.AddRange(new object[] {
            "Mięso",
            "Rośliny",
            "Mieszanka"});
            this.comboBoxJedzenieRodzaj.Location = new System.Drawing.Point(104, 234);
            this.comboBoxJedzenieRodzaj.Name = "comboBoxJedzenieRodzaj";
            this.comboBoxJedzenieRodzaj.Size = new System.Drawing.Size(206, 21);
            this.comboBoxJedzenieRodzaj.TabIndex = 15;
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
            // 
            // btnJedzenieZapisz
            // 
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
            this.dgvJedzenie.Size = new System.Drawing.Size(466, 565);
            this.dgvJedzenie.TabIndex = 0;
            // 
            // tabSektor
            // 
            this.tabSektor.Controls.Add(this.label9);
            this.tabSektor.Controls.Add(this.dataGridView9);
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
            this.label9.Location = new System.Drawing.Point(522, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Klatki";
            // 
            // dataGridView9
            // 
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Location = new System.Drawing.Point(525, 62);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.Size = new System.Drawing.Size(521, 554);
            this.dataGridView9.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sektory";
            // 
            // dgvSektory
            // 
            this.dgvSektory.AllowUserToAddRows = false;
            this.dgvSektory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSektory.Location = new System.Drawing.Point(31, 62);
            this.dgvSektory.Name = "dgvSektory";
            this.dgvSektory.RowHeadersVisible = false;
            this.dgvSektory.Size = new System.Drawing.Size(457, 554);
            this.dgvSektory.TabIndex = 9;
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
            this.tabKlatka.Controls.Add(this.dataGridView5);
            this.tabKlatka.Location = new System.Drawing.Point(4, 22);
            this.tabKlatka.Name = "tabKlatka";
            this.tabKlatka.Size = new System.Drawing.Size(1084, 667);
            this.tabKlatka.TabIndex = 3;
            this.tabKlatka.Text = "Klatka";
            this.tabKlatka.UseVisualStyleBackColor = true;
            // 
            // btnKlatkaEdytuj
            // 
            this.btnKlatkaEdytuj.Location = new System.Drawing.Point(253, 130);
            this.btnKlatkaEdytuj.Name = "btnKlatkaEdytuj";
            this.btnKlatkaEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnKlatkaEdytuj.TabIndex = 12;
            this.btnKlatkaEdytuj.Text = "Edytuj";
            this.btnKlatkaEdytuj.UseVisualStyleBackColor = true;
            this.btnKlatkaEdytuj.Click += new System.EventHandler(this.btnKlatkaEdytuj_Click);
            // 
            // btnKlatkaDodaj
            // 
            this.btnKlatkaDodaj.Location = new System.Drawing.Point(253, 64);
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
            this.label5.Location = new System.Drawing.Point(372, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Klatki";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(375, 64);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(457, 554);
            this.dataGridView5.TabIndex = 9;
            // 
            // tabZwierze
            // 
            this.tabZwierze.Controls.Add(this.button17);
            this.tabZwierze.Controls.Add(this.button18);
            this.tabZwierze.Controls.Add(this.label6);
            this.tabZwierze.Controls.Add(this.dataGridView6);
            this.tabZwierze.Location = new System.Drawing.Point(4, 22);
            this.tabZwierze.Name = "tabZwierze";
            this.tabZwierze.Size = new System.Drawing.Size(1084, 667);
            this.tabZwierze.TabIndex = 4;
            this.tabZwierze.Text = "Zwierzę";
            this.tabZwierze.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(3, 132);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 12;
            this.button17.Text = "Edytuj";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(3, 55);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 11;
            this.button18.Text = "Dodaj";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zwierzęcia";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(84, 55);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(457, 554);
            this.dataGridView6.TabIndex = 9;
            // 
            // tabOpieka
            // 
            this.tabOpieka.Controls.Add(this.button20);
            this.tabOpieka.Controls.Add(this.button21);
            this.tabOpieka.Controls.Add(this.label7);
            this.tabOpieka.Controls.Add(this.dataGridView7);
            this.tabOpieka.Location = new System.Drawing.Point(4, 22);
            this.tabOpieka.Name = "tabOpieka";
            this.tabOpieka.Size = new System.Drawing.Size(1084, 667);
            this.tabOpieka.TabIndex = 5;
            this.tabOpieka.Text = "Opieka";
            this.tabOpieka.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(253, 141);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 12;
            this.button20.Text = "Edytuj";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(253, 64);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 11;
            this.button21.Text = "Dodaj";
            this.button21.UseVisualStyleBackColor = true;
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
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(375, 64);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(457, 554);
            this.dataGridView7.TabIndex = 9;
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
            // dgvMagazynZawartosc
            // 
            this.dgvMagazynZawartosc.AllowUserToAddRows = false;
            this.dgvMagazynZawartosc.AllowUserToDeleteRows = false;
            this.dgvMagazynZawartosc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazynZawartosc.Location = new System.Drawing.Point(579, 54);
            this.dgvMagazynZawartosc.Name = "dgvMagazynZawartosc";
            this.dgvMagazynZawartosc.ReadOnly = true;
            this.dgvMagazynZawartosc.RowHeadersVisible = false;
            this.dgvMagazynZawartosc.Size = new System.Drawing.Size(474, 536);
            this.dgvMagazynZawartosc.TabIndex = 11;
            this.dgvMagazynZawartosc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sektorTA
            // 
            this.sektorTA.ClearBeforeFill = true;
            // 
            // txtKlatkaNazwa
            // 
            this.txtKlatkaNazwa.Location = new System.Drawing.Point(96, 66);
            this.txtKlatkaNazwa.Name = "txtKlatkaNazwa";
            this.txtKlatkaNazwa.Size = new System.Drawing.Size(100, 20);
            this.txtKlatkaNazwa.TabIndex = 13;
            // 
            // txtKlatkaWysokosc
            // 
            this.txtKlatkaWysokosc.Location = new System.Drawing.Point(96, 92);
            this.txtKlatkaWysokosc.Name = "txtKlatkaWysokosc";
            this.txtKlatkaWysokosc.Size = new System.Drawing.Size(100, 20);
            this.txtKlatkaWysokosc.TabIndex = 14;
            // 
            // txtKlatkaSzerokosc
            // 
            this.txtKlatkaSzerokosc.Location = new System.Drawing.Point(96, 118);
            this.txtKlatkaSzerokosc.Name = "txtKlatkaSzerokosc";
            this.txtKlatkaSzerokosc.Size = new System.Drawing.Size(100, 20);
            this.txtKlatkaSzerokosc.TabIndex = 15;
            // 
            // txtKlatkaGlebokosc
            // 
            this.txtKlatkaGlebokosc.Location = new System.Drawing.Point(96, 144);
            this.txtKlatkaGlebokosc.Name = "txtKlatkaGlebokosc";
            this.txtKlatkaGlebokosc.Size = new System.Drawing.Size(100, 20);
            this.txtKlatkaGlebokosc.TabIndex = 16;
            // 
            // comboBoxKlatkaSektor
            // 
            this.comboBoxKlatkaSektor.FormattingEnabled = true;
            this.comboBoxKlatkaSektor.Location = new System.Drawing.Point(96, 171);
            this.comboBoxKlatkaSektor.Name = "comboBoxKlatkaSektor";
            this.comboBoxKlatkaSektor.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKlatkaSektor.TabIndex = 17;
            // 
            // comboBoxKlatkaOpiekun
            // 
            this.comboBoxKlatkaOpiekun.FormattingEnabled = true;
            this.comboBoxKlatkaOpiekun.Location = new System.Drawing.Point(96, 198);
            this.comboBoxKlatkaOpiekun.Name = "comboBoxKlatkaOpiekun";
            this.comboBoxKlatkaOpiekun.Size = new System.Drawing.Size(100, 21);
            this.comboBoxKlatkaOpiekun.TabIndex = 18;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Wysokość";
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
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(33, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Głębokość";
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
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(46, 201);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "Opiekun";
            // 
            // btnKlatkaZapisz
            // 
            this.btnKlatkaZapisz.Location = new System.Drawing.Point(253, 196);
            this.btnKlatkaZapisz.Name = "btnKlatkaZapisz";
            this.btnKlatkaZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnKlatkaZapisz.TabIndex = 25;
            this.btnKlatkaZapisz.Text = "Zapisz";
            this.btnKlatkaZapisz.UseVisualStyleBackColor = true;
            // 
            // klatkaTA
            // 
            this.klatkaTA.ClearBeforeFill = true;
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
            this.tabMagazyn.ResumeLayout(false);
            this.tabMagazyn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazyny)).EndInit();
            this.tabOpiekun.ResumeLayout(false);
            this.tabOpiekun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpiekunowie)).EndInit();
            this.tabJedzenie.ResumeLayout(false);
            this.tabJedzenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedzenie)).EndInit();
            this.tabSektor.ResumeLayout(false);
            this.tabSektor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSektory)).EndInit();
            this.tabKlatka.ResumeLayout(false);
            this.tabKlatka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabZwierze.ResumeLayout(false);
            this.tabZwierze.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabOpieka.ResumeLayout(false);
            this.tabOpieka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiekunBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedzenieBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazynBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazynZawartosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klatkaBS)).EndInit();
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
		private System.Windows.Forms.DataGridView dataGridView9;
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
		private System.Windows.Forms.DataGridView dataGridView5;
		private System.Windows.Forms.TabPage tabZwierze;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dataGridView6;
		private System.Windows.Forms.TabPage tabOpieka;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView7;
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
    }
}

