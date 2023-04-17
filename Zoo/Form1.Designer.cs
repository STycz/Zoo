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
            this.tabJedzenie = new System.Windows.Forms.TabPage();
            this.button22 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabMagazyn = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabSektor = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabOpiekun = new System.Windows.Forms.TabPage();
            this.btnOpiekunEdytuj = new System.Windows.Forms.Button();
            this.btnOpiekunDodaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOpiekunowie = new System.Windows.Forms.DataGridView();
            this.tabKlatka = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
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
            this.mainDataSet = new Zoo.ZooDataSet();
            this.txtOpiekunImie = new System.Windows.Forms.TextBox();
            this.txtOpiekunNazwisko = new System.Windows.Forms.TextBox();
            this.txtOpiekunWiek = new System.Windows.Forms.TextBox();
            this.txtOpiekunNrTel = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.opiekunTA = new Zoo.ZooDataSetTableAdapters.OpiekunTableAdapter();
            this.comboBoxPlec = new System.Windows.Forms.ComboBox();
            this.btnOpiekunZapisz = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabJedzenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabMagazyn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabSektor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabOpiekun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpiekunowie)).BeginInit();
            this.tabKlatka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabZwierze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabOpieka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opiekunBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOpiekun);
            this.tabControl1.Controls.Add(this.tabJedzenie);
            this.tabControl1.Controls.Add(this.tabMagazyn);
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
            // tabJedzenie
            // 
            this.tabJedzenie.Controls.Add(this.button22);
            this.tabJedzenie.Controls.Add(this.button4);
            this.tabJedzenie.Controls.Add(this.button5);
            this.tabJedzenie.Controls.Add(this.button6);
            this.tabJedzenie.Controls.Add(this.label2);
            this.tabJedzenie.Controls.Add(this.dataGridView2);
            this.tabJedzenie.Location = new System.Drawing.Point(4, 22);
            this.tabJedzenie.Name = "tabJedzenie";
            this.tabJedzenie.Size = new System.Drawing.Size(1084, 667);
            this.tabJedzenie.TabIndex = 6;
            this.tabJedzenie.Text = "Jedzenie";
            this.tabJedzenie.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(334, 278);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(79, 34);
            this.button22.TabIndex = 12;
            this.button22.Text = "Info";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(334, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 34);
            this.button4.TabIndex = 11;
            this.button4.Text = "Usuń";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(334, 130);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 34);
            this.button5.TabIndex = 10;
            this.button5.Text = "Edytuj";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(334, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 34);
            this.button6.TabIndex = 9;
            this.button6.Text = "Dodaj";
            this.button6.UseVisualStyleBackColor = true;
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(449, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(466, 565);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabMagazyn
            // 
            this.tabMagazyn.Controls.Add(this.label11);
            this.tabMagazyn.Controls.Add(this.textBox1);
            this.tabMagazyn.Controls.Add(this.label10);
            this.tabMagazyn.Controls.Add(this.label8);
            this.tabMagazyn.Controls.Add(this.dataGridView10);
            this.tabMagazyn.Controls.Add(this.dataGridView8);
            this.tabMagazyn.Controls.Add(this.button2);
            this.tabMagazyn.Controls.Add(this.button1);
            this.tabMagazyn.Controls.Add(this.label1);
            this.tabMagazyn.Controls.Add(this.dataGridView1);
            this.tabMagazyn.Location = new System.Drawing.Point(4, 22);
            this.tabMagazyn.Name = "tabMagazyn";
            this.tabMagazyn.Padding = new System.Windows.Forms.Padding(3);
            this.tabMagazyn.Size = new System.Drawing.Size(1084, 667);
            this.tabMagazyn.TabIndex = 0;
            this.tabMagazyn.Text = "Magazyn";
            this.tabMagazyn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ilość";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Jedzenie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Magazyny";
            // 
            // dataGridView10
            // 
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Location = new System.Drawing.Point(210, 437);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.Size = new System.Drawing.Size(349, 170);
            this.dataGridView10.TabIndex = 9;
            // 
            // dataGridView8
            // 
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(210, 183);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.Size = new System.Drawing.Size(349, 170);
            this.dataGridView8.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edytuj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zawartość magazynu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(609, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 554);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabSektor
            // 
            this.tabSektor.Controls.Add(this.label9);
            this.tabSektor.Controls.Add(this.dataGridView9);
            this.tabSektor.Controls.Add(this.label3);
            this.tabSektor.Controls.Add(this.dataGridView3);
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(31, 62);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(457, 554);
            this.dataGridView3.TabIndex = 9;
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
            // 
            // tabKlatka
            // 
            this.tabKlatka.Controls.Add(this.button14);
            this.tabKlatka.Controls.Add(this.button15);
            this.tabKlatka.Controls.Add(this.label5);
            this.tabKlatka.Controls.Add(this.dataGridView5);
            this.tabKlatka.Location = new System.Drawing.Point(4, 22);
            this.tabKlatka.Name = "tabKlatka";
            this.tabKlatka.Size = new System.Drawing.Size(1084, 667);
            this.tabKlatka.TabIndex = 3;
            this.tabKlatka.Text = "Klatka";
            this.tabKlatka.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(253, 141);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 12;
            this.button14.Text = "Edytuj";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(253, 64);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 11;
            this.button15.Text = "Dodaj";
            this.button15.UseVisualStyleBackColor = true;
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
            // opiekunBS
            // 
            this.opiekunBS.DataSource = this.mainDataSet;
            this.opiekunBS.Position = 0;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "ZooDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtOpiekunImie
            // 
            this.txtOpiekunImie.Location = new System.Drawing.Point(92, 66);
            this.txtOpiekunImie.Name = "txtOpiekunImie";
            this.txtOpiekunImie.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunImie.TabIndex = 13;
            // 
            // txtOpiekunNazwisko
            // 
            this.txtOpiekunNazwisko.Location = new System.Drawing.Point(92, 105);
            this.txtOpiekunNazwisko.Name = "txtOpiekunNazwisko";
            this.txtOpiekunNazwisko.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunNazwisko.TabIndex = 14;
            // 
            // txtOpiekunWiek
            // 
            this.txtOpiekunWiek.Location = new System.Drawing.Point(92, 144);
            this.txtOpiekunWiek.Name = "txtOpiekunWiek";
            this.txtOpiekunWiek.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunWiek.TabIndex = 15;
            // 
            // txtOpiekunNrTel
            // 
            this.txtOpiekunNrTel.Location = new System.Drawing.Point(92, 222);
            this.txtOpiekunNrTel.Name = "txtOpiekunNrTel";
            this.txtOpiekunNrTel.Size = new System.Drawing.Size(122, 20);
            this.txtOpiekunNrTel.TabIndex = 17;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Nazwisko";
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Płeć";
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
            // opiekunTA
            // 
            this.opiekunTA.ClearBeforeFill = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 788);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabJedzenie.ResumeLayout(false);
            this.tabJedzenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabMagazyn.ResumeLayout(false);
            this.tabMagazyn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabSektor.ResumeLayout(false);
            this.tabSektor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabOpiekun.ResumeLayout(false);
            this.tabOpiekun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpiekunowie)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabJedzenie;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TabPage tabMagazyn;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridView10;
		private System.Windows.Forms.DataGridView dataGridView8;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabPage tabSektor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView dataGridView9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.TabPage tabOpiekun;
		private System.Windows.Forms.Button btnOpiekunEdytuj;
		private System.Windows.Forms.Button btnOpiekunDodaj;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvOpiekunowie;
		private System.Windows.Forms.TabPage tabKlatka;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
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
        private System.Windows.Forms.BindingSource opiekunBS;
        private ZooDataSet mainDataSet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOpiekunNrTel;
        private System.Windows.Forms.TextBox txtOpiekunWiek;
        private System.Windows.Forms.TextBox txtOpiekunNazwisko;
        private System.Windows.Forms.TextBox txtOpiekunImie;
        private ZooDataSetTableAdapters.OpiekunTableAdapter opiekunTA;
        private System.Windows.Forms.ComboBox comboBoxPlec;
        private System.Windows.Forms.Button btnOpiekunZapisz;
    }
}

