using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo
{
    public partial class Form1 : Form
    {
        private void ResetData()
        {
            txtOpiekunImie.Text = "";
            txtOpiekunNazwisko.Text = "";
            txtOpiekunWiek.Text = "";
            comboBoxPlec.SelectedIndex = -1;
            txtOpiekunNrTel.Text = "";

            txtJedzenieNazwa.Text = "";
            txtJedzenieOpis.Text = "";
            comboBoxJedzenieRodzaj.SelectedIndex = -1;
            comboBoxJedzenieMagID.SelectedIndex = -1;

            txtKlatkaNazwa.Text = "";
            txtKlatkaWysokosc.Text = "";
            txtKlatkaSzerokosc.Text = "";
            txtKlatkaGlebokosc.Text = "";
            comboBoxKlatkaSektor.SelectedIndex = -1;
            comboBoxKlatkaOpiekun.SelectedIndex = -1;

            txtZwierzeNazwa.Text = "";
            txtZwierzeWiek.Text = "";
            comboBoxZwierzeGromada.SelectedIndex = -1;
            comboBoxZwierzePlec.SelectedIndex = -1;
            txtZwierzeDataPrzyjecia.Text = "";
            comboBoxZwierzeKlatka.SelectedIndex = -1;

            maskedTxtOpiekaRozpOpieki.Text = "";
            maskedTxtOpiekaKonOpieki.Text = "";
            txtOpiekaData.Text = "";
            comboBoxOpiekaZwierze.SelectedIndex = -1;
            comboBoxOpiekaOpiekun.SelectedIndex = -1;

            this.dbAction = DBActions.None;
        }

        

        private DBActions dbAction = DBActions.None;
        ZooDataSet.OpiekunRow _selectedRow = null;
        ZooDataSet.JedzenieRow _selectedRowJedzenie = null;
        ZooDataSet.Klatka_zwierzeciaRow _selectedRowKlatka = null;
        ZooDataSet.ZwierzecieRow _selectedRowZwierze = null;
        ZooDataSet.OpiekaRow _selectedRowOpieka = null;

        private bool ValidateInput()
        {
            //Validations
            return true;
        }
        public Form1()
        {
            InitializeComponent();
            //LOADING

            try
            {
                //1. fill data set
                opiekunTA.Fill(mainDataSet.Opiekun);
                //2. add datasource to binding source
                opiekunBS.DataSource = mainDataSet.Opiekun;
                //3. set datagridview source
                dgvOpiekunowie.DataSource = opiekunBS;
                

                jedzenieTA.Fill(mainDataSet.Jedzenie);
                jedzenieBS.DataSource = mainDataSet.Jedzenie;
                dgvJedzenie.DataSource = jedzenieBS;
                dgvJedzenie.Columns[0].Visible = false;
                dgvJedzenie.Columns[4].HeaderText = "Magazyn";


                magazynTA.Fill(mainDataSet.Magazyn);
                magazynBS.DataSource = mainDataSet.Magazyn;
                dgvMagazyny.DataSource = magazynBS;
                dgvMagazyny.Columns[0].Visible = true;

                dgvMagazynZawartosc.DataSource = jedzenieBS;

                sektorTA.Fill(mainDataSet.Sektor);
                sektorBS.DataSource = mainDataSet.Sektor;
                dgvSektory.DataSource = sektorBS;
                
                klatkaTA.Fill(mainDataSet.Klatka_zwierzecia);
                klatkaBS.DataSource = mainDataSet.Klatka_zwierzecia;
                dgvKlatki.DataSource = klatkaBS;
                comboBoxKlatkaOpiekun.DataSource = opiekunBS;
                comboBoxKlatkaOpiekun.DisplayMember = "ID_Opiekun";
                comboBoxKlatkaOpiekun.ValueMember = "ID_Opiekun";

                zwierzeTA.Fill(mainDataSet.Zwierzecie);
                zwierzeBS.DataSource = mainDataSet.Zwierzecie;
                dgvZwierzeta.DataSource = zwierzeBS;
                dgvZwierzeta.Columns[3].HeaderText = "Gromada";
                comboBoxZwierzeKlatka.DataSource = klatkaBS;
                comboBoxZwierzeKlatka.DisplayMember = "ID_Klatka";
                comboBoxZwierzeKlatka.ValueMember = "ID_Klatka";

                opiekaTA.Fill(mainDataSet.Opieka);
                opiekaBS.DataSource = mainDataSet.Opieka;
                dgvOpieki.DataSource = opiekaBS;
                comboBoxOpiekaZwierze.DataSource = zwierzeBS;
                comboBoxOpiekaZwierze.DisplayMember = "ID_Zwierze";
                comboBoxOpiekaZwierze.ValueMember = "ID_Zwierze";
                comboBoxOpiekaOpiekun.DataSource = opiekunBS;
                comboBoxOpiekaOpiekun.DisplayMember = "ID_Opiekun";
                comboBoxOpiekaOpiekun.ValueMember = "ID_Opiekun";

                comboBoxJedzenieMagID.DataSource = magazynBS;
                comboBoxJedzenieMagID.DisplayMember = "ID_Magazyn";
                comboBoxJedzenieMagID.ValueMember = "ID_Magazyn";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }

        }

        

        public enum DBActions
        {
            None,
            Add,
            Edit,
            Delete
        }

        private void btnOpiekunDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedRow = mainDataSet.Opiekun.NewOpiekunRow();
                ResetData();
                txtOpiekunImie.Focus();
                this.dbAction = DBActions.Add;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnOpiekunEdytuj_Click(object sender, EventArgs e)
        {
            try
            {
                var row = ((DataRowView)opiekunBS.Current).Row as ZooDataSet.OpiekunRow;

                if (row == null)
                    return;
                
                _selectedRow = row;
                dbAction = DBActions.Edit;

                txtOpiekunImie.Text = _selectedRow.Imie;
                txtOpiekunNazwisko.Text = _selectedRow.Nazwisko;
                txtOpiekunWiek.Text = _selectedRow.Wiek.ToString();
                comboBoxPlec.Text = _selectedRow.Plec;
                txtOpiekunNrTel.Text = _selectedRow.Nr_telefonu;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnOpiekunZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                if(!ValidateInput())
                    return;

                if (_selectedRow == null)
                    return;

                switch (dbAction)
                {
                    case DBActions.Edit:
                        {
                            _selectedRow.Imie = txtOpiekunImie.Text;
                            _selectedRow.Nazwisko = txtOpiekunNazwisko.Text;
                            _selectedRow.Wiek = Int32.Parse(txtOpiekunWiek.Text);
                            _selectedRow.Plec = comboBoxPlec.Text;
                            _selectedRow.Nr_telefonu = txtOpiekunNrTel.Text;

                            opiekunTA.Update(_selectedRow);
                            mainDataSet.Opiekun.AcceptChanges();

                            break;
                        }
                    case DBActions.Add:
                        {
                            _selectedRow.Imie = txtOpiekunImie.Text;
                            _selectedRow.Nazwisko = txtOpiekunNazwisko.Text;
                            _selectedRow.Wiek = Int32.Parse(txtOpiekunWiek.Text);
                            _selectedRow.Plec = comboBoxPlec.Text;
                            _selectedRow.Nr_telefonu = txtOpiekunNrTel.Text;

                            mainDataSet.Opiekun.AddOpiekunRow(_selectedRow);
                            opiekunTA.Update(_selectedRow);
                            mainDataSet.AcceptChanges();

                            break;
                        }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void dgvOpiekunowie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnJedzenieDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedRowJedzenie = mainDataSet.Jedzenie.NewJedzenieRow();
                ResetData();
                txtJedzenieNazwa.Focus();
                this.dbAction = DBActions.Add;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnJedzenieEdytuj_Click(object sender, EventArgs e)
        {
            try
            {
                var row = ((DataRowView)jedzenieBS.Current).Row as ZooDataSet.JedzenieRow;

                if (row == null)
                    return;

                _selectedRowJedzenie = row;
                dbAction = DBActions.Edit;

                txtJedzenieNazwa.Text = _selectedRowJedzenie.Nazwa;
                txtJedzenieOpis.Text = _selectedRowJedzenie.Opis;
                comboBoxJedzenieRodzaj.Text = _selectedRowJedzenie.Rodzaj;
                comboBoxJedzenieMagID.Text = _selectedRowJedzenie.ID_Magazyn.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnJedzenieZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                if (_selectedRowJedzenie == null)
                    return;

                switch (dbAction)
                {
                    case DBActions.Edit:
                        {
                            _selectedRowJedzenie.Nazwa = txtJedzenieNazwa.Text;
                            _selectedRowJedzenie.Opis = txtJedzenieOpis.Text;
                            _selectedRowJedzenie.Rodzaj = comboBoxJedzenieRodzaj.Text;
                            _selectedRowJedzenie.ID_Magazyn = Int32.Parse(comboBoxJedzenieMagID.Text);

                            
                            jedzenieTA.Update(_selectedRowJedzenie);
                            mainDataSet.AcceptChanges();

                            break;
                        }
                    case DBActions.Add:
                        {
                            _selectedRowJedzenie.Nazwa = txtJedzenieNazwa.Text;
                            _selectedRowJedzenie.Opis = txtJedzenieOpis.Text;
                            _selectedRowJedzenie.Rodzaj = comboBoxJedzenieRodzaj.Text;
                            _selectedRowJedzenie.ID_Magazyn = Int32.Parse(comboBoxJedzenieMagID.Text);

                            mainDataSet.Jedzenie.AddJedzenieRow(_selectedRowJedzenie);
                            jedzenieTA.Update(_selectedRowJedzenie);
                            mainDataSet.Jedzenie.AcceptChanges();

                            break;
                        }
                    case DBActions.Delete:
                        {
                            mainDataSet.Jedzenie.RemoveJedzenieRow(_selectedRowJedzenie);
                            jedzenieTA.Update(_selectedRowJedzenie);
                            mainDataSet.Jedzenie.AcceptChanges();

                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnJedzenieUsun_Click(object sender, EventArgs e)
        {
            try
            {
                var row1 = ((DataRowView)jedzenieBS.Current).Row as ZooDataSet.JedzenieRow;

                if (row1 == null)
                    return;

                _selectedRowJedzenie = row1;
                dbAction = DBActions.Delete;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMagazyny_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                string selectedValue = dgvMagazyny.Rows[e.RowIndex].Cells[0].Value.ToString();

                DataTable originalTable = (DataTable)jedzenieBS.DataSource;

                DataTable filteredTable = new DataTable();
                foreach (DataColumn column in originalTable.Columns)
                {
                    filteredTable.Columns.Add(column.ColumnName, column.DataType);
                }

                foreach (DataRow row in originalTable.Rows)
                {
                    if (row[4].ToString() == selectedValue)
                    {
                        filteredTable.Rows.Add(row.ItemArray);
                    }
                }

                dgvMagazynZawartosc.DataSource = filteredTable;
            }
        }

        private void btnKlatkaDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedRowKlatka = mainDataSet.Klatka_zwierzecia.NewKlatka_zwierzeciaRow();
                ResetData();
                txtKlatkaNazwa.Focus();
                this.dbAction = DBActions.Add;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnKlatkaEdytuj_Click(object sender, EventArgs e)
        {
            try
            {
                var row = ((DataRowView)klatkaBS.Current).Row as ZooDataSet.Klatka_zwierzeciaRow;

                if (row == null)
                    return;

                _selectedRowKlatka = row;
                dbAction = DBActions.Edit;

                txtKlatkaNazwa.Text = _selectedRowKlatka.Nazwa;
                txtKlatkaWysokosc.Text = _selectedRowKlatka.Wysokosc.ToString();
                txtKlatkaSzerokosc.Text = _selectedRowKlatka.Szerokosc.ToString();
                txtKlatkaGlebokosc.Text = _selectedRowKlatka.Glebokosc.ToString();
                comboBoxKlatkaSektor.Text = _selectedRowKlatka.ID_Sektor.ToString();
                comboBoxKlatkaOpiekun.Text = _selectedRowKlatka.ID_Opiekun.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnKlatkaZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                if (_selectedRowKlatka == null)
                    return;

                switch (dbAction)
                {
                    case DBActions.Edit:
                        {
                            _selectedRowKlatka.Nazwa = txtKlatkaNazwa.Text;
                            _selectedRowKlatka.Wysokosc = Int32.Parse(txtKlatkaWysokosc.Text);
                            _selectedRowKlatka.Szerokosc = Int32.Parse(txtKlatkaSzerokosc.Text);
                            _selectedRowKlatka.Glebokosc = Int32.Parse(txtKlatkaGlebokosc.Text);
                            _selectedRowKlatka.ID_Sektor = Int32.Parse(comboBoxKlatkaSektor.Text);
                            _selectedRowKlatka.ID_Opiekun = Int32.Parse(comboBoxKlatkaOpiekun.Text);


                            klatkaTA.Update(_selectedRowKlatka);
                            mainDataSet.AcceptChanges();

                            break;
                        }
                    case DBActions.Add:
                        {
                            _selectedRowKlatka.Nazwa = txtKlatkaNazwa.Text;
                            _selectedRowKlatka.Wysokosc = Int32.Parse(txtKlatkaWysokosc.Text);
                            _selectedRowKlatka.Szerokosc = Int32.Parse(txtKlatkaSzerokosc.Text);
                            _selectedRowKlatka.Glebokosc = Int32.Parse(txtKlatkaGlebokosc.Text);
                            _selectedRowKlatka.ID_Sektor = Int32.Parse(comboBoxKlatkaSektor.Text);
                            _selectedRowKlatka.ID_Opiekun = Int32.Parse(comboBoxKlatkaOpiekun.Text);

                            mainDataSet.Klatka_zwierzecia.AddKlatka_zwierzeciaRow(_selectedRowKlatka);
                            klatkaTA.Update(_selectedRowKlatka);
                            mainDataSet.Klatka_zwierzecia.AcceptChanges();

                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void dgvSektorKlatki_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSektory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedValue = dgvSektory.Rows[e.RowIndex].Cells[0].Value.ToString();

                DataTable originalTable = (DataTable)klatkaBS.DataSource;

                DataTable filteredTable = new DataTable();
                foreach (DataColumn column in originalTable.Columns)
                {
                    filteredTable.Columns.Add(column.ColumnName, column.DataType);
                }

                foreach (DataRow row in originalTable.Rows)
                {
                    if (row[5].ToString() == selectedValue)
                    {
                        filteredTable.Rows.Add(row.ItemArray);
                    }
                }

                dgvSektorKlatki.DataSource = filteredTable;
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void btnZwierzeDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedRowZwierze = mainDataSet.Zwierzecie.NewZwierzecieRow();
                ResetData();
                txtZwierzeNazwa.Focus();
                this.dbAction = DBActions.Add;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnZwierzeEdytuj_Click(object sender, EventArgs e)
        {
            try
            {
                var row = ((DataRowView)zwierzeBS.Current).Row as ZooDataSet.ZwierzecieRow;

                if (row == null)
                    return;

                _selectedRowZwierze = row;
                dbAction = DBActions.Edit;

                txtZwierzeNazwa.Text = _selectedRowZwierze.Nazwa;
                txtZwierzeWiek.Text = _selectedRowZwierze.Wiek.ToString();
                comboBoxZwierzeGromada.Text = _selectedRowZwierze.Gatunek;
                comboBoxZwierzePlec.Text = _selectedRowZwierze.Plec;
                txtZwierzeDataPrzyjecia.Text = _selectedRowZwierze.Data_przyjecia;
                comboBoxZwierzeKlatka.Text = _selectedRowZwierze.ID_Klatka.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnZwierzeZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                if (_selectedRowZwierze == null)
                    return;

                switch (dbAction)
                {
                    case DBActions.Edit:
                        {
                            _selectedRowZwierze.Nazwa = txtZwierzeNazwa.Text;
                            _selectedRowZwierze.Wiek = Int32.Parse(txtZwierzeWiek.Text);
                            _selectedRowZwierze.Gatunek = comboBoxZwierzeGromada.Text;
                            _selectedRowZwierze.Plec = comboBoxZwierzePlec.Text;
                            _selectedRowZwierze.Data_przyjecia = txtZwierzeDataPrzyjecia.Text;
                            _selectedRowZwierze.ID_Klatka = Int32.Parse(comboBoxZwierzeKlatka.Text);


                            zwierzeTA.Update(_selectedRowZwierze);
                            mainDataSet.AcceptChanges();

                            break;
                        }
                    case DBActions.Add:
                        {
                            _selectedRowZwierze.Nazwa = txtZwierzeNazwa.Text;
                            _selectedRowZwierze.Wiek = Int32.Parse(txtZwierzeWiek.Text);
                            _selectedRowZwierze.Gatunek = comboBoxZwierzeGromada.Text;
                            _selectedRowZwierze.Plec = comboBoxZwierzePlec.Text;
                            _selectedRowZwierze.Data_przyjecia = txtZwierzeDataPrzyjecia.Text;
                            _selectedRowZwierze.ID_Klatka = Int32.Parse(comboBoxZwierzeKlatka.Text);

                            mainDataSet.Zwierzecie.AddZwierzecieRow(_selectedRowZwierze);
                            zwierzeTA.Update(_selectedRowZwierze);
                            mainDataSet.Zwierzecie.AcceptChanges();

                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnOpiekaDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedRowOpieka = mainDataSet.Opieka.NewOpiekaRow();
                ResetData();
                maskedTxtOpiekaRozpOpieki.Focus();
                this.dbAction = DBActions.Add;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnOpiekaEdytuj_Click(object sender, EventArgs e)
        {
            try
            {
                var row = ((DataRowView)opiekaBS.Current).Row as ZooDataSet.OpiekaRow;

                if (row == null)
                    return;

                _selectedRowOpieka = row;
                dbAction = DBActions.Edit;

                maskedTxtOpiekaRozpOpieki.Text = _selectedRowOpieka.Start_opieki;
                maskedTxtOpiekaKonOpieki.Text = _selectedRowOpieka.Koniec_opieki;
                txtOpiekaData.Text = _selectedRowOpieka.Data;
                comboBoxOpiekaZwierze.Text = _selectedRowOpieka.ID_Zwierze.ToString();
                comboBoxOpiekaOpiekun.Text = _selectedRowOpieka.ID_Opiekun.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void btnOpiekaZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                if (_selectedRowOpieka == null)
                    return;

                switch (dbAction)
                {
                    case DBActions.Edit:
                        {
                            _selectedRowOpieka.Start_opieki = maskedTxtOpiekaRozpOpieki.Text;
                            _selectedRowOpieka.Koniec_opieki = maskedTxtOpiekaKonOpieki.Text;
                            _selectedRowOpieka.Data = txtOpiekaData.Text;
                            _selectedRowOpieka.ID_Zwierze = Int32.Parse(comboBoxOpiekaZwierze.Text);
                            _selectedRowOpieka.ID_Opiekun = Int32.Parse(comboBoxOpiekaOpiekun.Text);

                            opiekaTA.Update(_selectedRowOpieka);
                            mainDataSet.AcceptChanges();

                            break;
                        }
                    case DBActions.Add:
                        {
                            _selectedRowOpieka.Start_opieki = maskedTxtOpiekaRozpOpieki.Text;
                            _selectedRowOpieka.Koniec_opieki = maskedTxtOpiekaKonOpieki.Text;
                            _selectedRowOpieka.Data = txtOpiekaData.Text;
                            _selectedRowOpieka.ID_Zwierze = Int32.Parse(comboBoxOpiekaZwierze.Text);
                            _selectedRowOpieka.ID_Opiekun = Int32.Parse(comboBoxOpiekaOpiekun.Text);

                            mainDataSet.Opieka.AddOpiekaRow(_selectedRowOpieka);
                            opiekaTA.Update(_selectedRowOpieka);
                            mainDataSet.Opieka.AcceptChanges();

                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void txtOpiekunImie_TextChanged_1(object sender, EventArgs e)
        {
            if (txtOpiekunNrTel.Text.Length == 9 && comboBoxPlec.SelectedIndex != -1 && txtOpiekunNazwisko.Text.Length >= 3 && int.TryParse(txtOpiekunWiek.Text, out int age) && age >= 18 && age <= 70 && txtOpiekunImie.Text.Length >= 3)
            {
                btnOpiekunZapisz.Enabled = true;
            }
            else
            {
                btnOpiekunZapisz.Enabled = false;
            }
        }

        private void txtOpiekunImie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOpiekunNazwisko_TextChanged(object sender, EventArgs e)
        {
            if (txtOpiekunNrTel.Text.Length == 9 && comboBoxPlec.SelectedIndex != -1 && txtOpiekunNazwisko.Text.Length >= 3 && int.TryParse(txtOpiekunWiek.Text, out int age) && age >= 18 && age <= 70 && txtOpiekunImie.Text.Length >= 3)
            {
                btnOpiekunZapisz.Enabled = true;
            }
            else
            {
                btnOpiekunZapisz.Enabled = false;
            }
        }

        private void txtOpiekunNazwisko_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOpiekunWiek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOpiekunWiek_TextChanged(object sender, EventArgs e)
        {
            if (txtOpiekunNrTel.Text.Length == 9 && comboBoxPlec.SelectedIndex != -1 && txtOpiekunNazwisko.Text.Length >= 3 && int.TryParse(txtOpiekunWiek.Text, out int age) && age >= 18 && age <= 70 && txtOpiekunImie.Text.Length >= 3)
            {
                btnOpiekunZapisz.Enabled = true;
            }
            else
            {
                btnOpiekunZapisz.Enabled = false;
            }
        }

        private void txtOpiekunNrTel_TextChanged(object sender, EventArgs e)
        {
            if (txtOpiekunNrTel.Text.Length == 9 && comboBoxPlec.SelectedIndex != -1 && txtOpiekunNazwisko.Text.Length >= 3 && int.TryParse(txtOpiekunWiek.Text, out int age) && age >= 18 && age <= 70 && txtOpiekunImie.Text.Length >= 3)
            {
                btnOpiekunZapisz.Enabled = true;
            }
            else
            {
                btnOpiekunZapisz.Enabled = false;
            }
        }

        private void txtOpiekunNrTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtJedzenieNazwa_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxJedzenieMagID.SelectedIndex != -1 && comboBoxJedzenieRodzaj.SelectedIndex != -1 && txtJedzenieNazwa.Text.Length >= 3)
            {
                btnJedzenieZapisz.Enabled = true;
            }
            else
            {
                btnJedzenieZapisz.Enabled = false;
            }
        }

        private void comboBoxJedzenieRodzaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxJedzenieMagID.SelectedIndex != -1 && comboBoxJedzenieRodzaj.SelectedIndex != -1 && txtJedzenieNazwa.Text.Length >= 3)
            {
                btnJedzenieZapisz.Enabled = true;
            }
            else
            {
                btnJedzenieZapisz.Enabled = false;
            }
        }

        private void comboBoxJedzenieMagID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxJedzenieMagID.SelectedIndex != -1 && comboBoxJedzenieRodzaj.SelectedIndex != -1 && txtJedzenieNazwa.Text.Length >= 3)
            {
                btnJedzenieZapisz.Enabled = true;
            }
            else
            {
                btnJedzenieZapisz.Enabled = false;
            }
        }

        private void comboBoxPlec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtOpiekunNrTel.Text.Length == 9 && comboBoxPlec.SelectedIndex != -1 && txtOpiekunNazwisko.Text.Length >= 3 && int.TryParse(txtOpiekunWiek.Text, out int age) && age >= 18 && age <= 70 && txtOpiekunImie.Text.Length >= 3)
            {
                btnOpiekunZapisz.Enabled = true;
            }
            else
            {
                btnOpiekunZapisz.Enabled = false;
            }
        }

        private void txtKlatkaNazwa_TextChanged(object sender, EventArgs e)
        {
            if (txtKlatkaNazwa.Text.Length >= 2 && int.TryParse(txtKlatkaWysokosc.Text, out int wysokosc) && wysokosc >= 50 && int.TryParse(txtKlatkaSzerokosc.Text, out int szerokosc) && szerokosc >= 50 && int.TryParse(txtKlatkaGlebokosc.Text, out int glebokosc) && glebokosc >= 50 && comboBoxKlatkaSektor.SelectedIndex != -1 && comboBoxKlatkaOpiekun.SelectedIndex != -1)
            {
                btnKlatkaZapisz.Enabled = true;
            }
            else
            {
                btnKlatkaZapisz.Enabled = false;
            }
        }

        private void txtKlatkaNazwa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtKlatkaWysokosc_TextChanged(object sender, EventArgs e)
        {
            if (txtKlatkaNazwa.Text.Length >= 2 && int.TryParse(txtKlatkaWysokosc.Text, out int wysokosc) && wysokosc >= 50 && int.TryParse(txtKlatkaSzerokosc.Text, out int szerokosc) && szerokosc >= 50 && int.TryParse(txtKlatkaGlebokosc.Text, out int glebokosc) && glebokosc >= 50 && comboBoxKlatkaSektor.SelectedIndex != -1 && comboBoxKlatkaOpiekun.SelectedIndex != -1)
            {
                btnKlatkaZapisz.Enabled = true;
            }
            else
            {
                btnKlatkaZapisz.Enabled = false;
            }
        }

        private void txtKlatkaWysokosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKlatkaSzerokosc_TextChanged(object sender, EventArgs e)
        {
            if (txtKlatkaNazwa.Text.Length >= 2 && int.TryParse(txtKlatkaWysokosc.Text, out int wysokosc) && wysokosc >= 50 && int.TryParse(txtKlatkaSzerokosc.Text, out int szerokosc) && szerokosc >= 50 && int.TryParse(txtKlatkaGlebokosc.Text, out int glebokosc) && glebokosc >= 50 && comboBoxKlatkaSektor.SelectedIndex != -1 && comboBoxKlatkaOpiekun.SelectedIndex != -1)
            {
                btnKlatkaZapisz.Enabled = true;
            }
            else
            {
                btnKlatkaZapisz.Enabled = false;
            }
        }

        private void txtKlatkaSzerokosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtKlatkaGlebokosc_TextChanged(object sender, EventArgs e)
        {
            if (txtKlatkaNazwa.Text.Length >= 2 && int.TryParse(txtKlatkaWysokosc.Text, out int wysokosc) && wysokosc >= 50 && int.TryParse(txtKlatkaSzerokosc.Text, out int szerokosc) && szerokosc >= 50 && int.TryParse(txtKlatkaGlebokosc.Text, out int glebokosc) && glebokosc >= 50 && comboBoxKlatkaSektor.SelectedIndex != -1 && comboBoxKlatkaOpiekun.SelectedIndex != -1)
            {
                btnKlatkaZapisz.Enabled = true;
            }
            else
            {
                btnKlatkaZapisz.Enabled = false;
            }
        }

        private void txtKlatkaGlebokosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxKlatkaSektor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtKlatkaNazwa.Text.Length >= 2 && int.TryParse(txtKlatkaWysokosc.Text, out int wysokosc) && wysokosc >= 50 && int.TryParse(txtKlatkaSzerokosc.Text, out int szerokosc) && szerokosc >= 50 && int.TryParse(txtKlatkaGlebokosc.Text, out int glebokosc) && glebokosc >= 50 && comboBoxKlatkaSektor.SelectedIndex != -1 && comboBoxKlatkaOpiekun.SelectedIndex != -1)
            {
                btnKlatkaZapisz.Enabled = true;
            }
            else
            {
                btnKlatkaZapisz.Enabled = false;
            }
        }

        private void comboBoxKlatkaOpiekun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtKlatkaNazwa.Text.Length >= 2 && int.TryParse(txtKlatkaWysokosc.Text, out int wysokosc) && wysokosc >= 50 && int.TryParse(txtKlatkaSzerokosc.Text, out int szerokosc) && szerokosc >= 50 && int.TryParse(txtKlatkaGlebokosc.Text, out int glebokosc) && glebokosc >= 50 && comboBoxKlatkaSektor.SelectedIndex != -1 && comboBoxKlatkaOpiekun.SelectedIndex != -1)
            {
                btnKlatkaZapisz.Enabled = true;
            }
            else
            {
                btnKlatkaZapisz.Enabled = false;
            }
        }

        private void txtZwierzeNazwa_TextChanged(object sender, EventArgs e)
        {
            if (txtZwierzeNazwa.Text.Length >= 3 && int.TryParse(txtZwierzeWiek.Text, out int wiek) && wiek >= 0 && wiek <= 500 && comboBoxZwierzeGromada.SelectedIndex != -1 && comboBoxZwierzePlec.SelectedIndex != -1 && txtZwierzeDataPrzyjecia.Text.Length >= 8 && txtZwierzeDataPrzyjecia.Text.Length <= 20 && comboBoxZwierzeKlatka.SelectedIndex != -1)
            {
                btnZwierzeZapisz.Enabled = true;
            }
            else
            {
                btnZwierzeZapisz.Enabled = false;
            }
        }

        private void txtZwierzeWiek_TextChanged(object sender, EventArgs e)
        {
            if (txtZwierzeNazwa.Text.Length >= 3 && int.TryParse(txtZwierzeWiek.Text, out int wiek) && wiek >= 0 && wiek <= 500 && comboBoxZwierzeGromada.SelectedIndex != -1 && comboBoxZwierzePlec.SelectedIndex != -1 && txtZwierzeDataPrzyjecia.Text.Length >= 8 && txtZwierzeDataPrzyjecia.Text.Length <= 20 && comboBoxZwierzeKlatka.SelectedIndex != -1)
            {
                btnZwierzeZapisz.Enabled = true;
            }
            else
            {
                btnZwierzeZapisz.Enabled = false;
            }
        }

        private void txtZwierzeWiek_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBoxZwierzeGromada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtZwierzeNazwa.Text.Length >= 3 && int.TryParse(txtZwierzeWiek.Text, out int wiek) && wiek >= 0 && wiek <= 500 && comboBoxZwierzeGromada.SelectedIndex != -1 && comboBoxZwierzePlec.SelectedIndex != -1 && txtZwierzeDataPrzyjecia.Text.Length >= 8 && txtZwierzeDataPrzyjecia.Text.Length <= 20 && comboBoxZwierzeKlatka.SelectedIndex != -1)
            {
                btnZwierzeZapisz.Enabled = true;
            }
            else
            {
                btnZwierzeZapisz.Enabled = false;
            }
        }

        private void comboBoxZwierzePlec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtZwierzeNazwa.Text.Length >= 3 && int.TryParse(txtZwierzeWiek.Text, out int wiek) && wiek >= 0 && wiek <= 500 && comboBoxZwierzeGromada.SelectedIndex != -1 && comboBoxZwierzePlec.SelectedIndex != -1 && txtZwierzeDataPrzyjecia.Text.Length >= 8 && txtZwierzeDataPrzyjecia.Text.Length <= 20 && comboBoxZwierzeKlatka.SelectedIndex != -1)
            {
                btnZwierzeZapisz.Enabled = true;
            }
            else
            {
                btnZwierzeZapisz.Enabled = false;
            }
        }

        private void txtZwierzeDataPrzyjecia_TextChanged(object sender, EventArgs e)
        {
            if (txtZwierzeNazwa.Text.Length >= 3 && int.TryParse(txtZwierzeWiek.Text, out int wiek) && wiek >= 0 && wiek <= 500 && comboBoxZwierzeGromada.SelectedIndex != -1 && comboBoxZwierzePlec.SelectedIndex != -1 && txtZwierzeDataPrzyjecia.Text.Length >= 8 && txtZwierzeDataPrzyjecia.Text.Length <= 20 && comboBoxZwierzeKlatka.SelectedIndex != -1)
            {
                btnZwierzeZapisz.Enabled = true;
            }
            else
            {
                btnZwierzeZapisz.Enabled = false;
            }
        }

        private void comboBoxZwierzeKlatka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtZwierzeNazwa.Text.Length >= 3 && int.TryParse(txtZwierzeWiek.Text, out int wiek) && wiek >= 0 && wiek <= 500 && comboBoxZwierzeGromada.SelectedIndex != -1 && comboBoxZwierzePlec.SelectedIndex != -1 && txtZwierzeDataPrzyjecia.Text.Length >= 8 && txtZwierzeDataPrzyjecia.Text.Length <= 20 && comboBoxZwierzeKlatka.SelectedIndex != -1)
            {
                btnZwierzeZapisz.Enabled = true;
            }
            else
            {
                btnZwierzeZapisz.Enabled = false;
            }
        }

        private void maskedTxtOpiekaRozpOpieki_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTxtOpiekaRozpOpieki.Text.Length == 5 && maskedTxtOpiekaKonOpieki.Text.Length == 5 && txtOpiekaData.Text.Length >= 8 && txtOpiekaData.Text.Length <= 20 && comboBoxOpiekaZwierze.SelectedIndex != -1 && comboBoxOpiekaOpiekun.SelectedIndex != -1)
            {
                btnOpiekaZapisz.Enabled = true;
            }
            else
            {
                btnOpiekaZapisz.Enabled = false;
            }
        }

        private void maskedTxtOpiekaKonOpieki_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTxtOpiekaRozpOpieki.Text.Length == 5 && maskedTxtOpiekaKonOpieki.Text.Length == 5 && txtOpiekaData.Text.Length >= 8 && txtOpiekaData.Text.Length <= 20 && comboBoxOpiekaZwierze.SelectedIndex != -1 && comboBoxOpiekaOpiekun.SelectedIndex != -1)
            {
                btnOpiekaZapisz.Enabled = true;
            }
            else
            {
                btnOpiekaZapisz.Enabled = false;
            }
        }

        private void txtOpiekaData_TextChanged(object sender, EventArgs e)
        {
            if (maskedTxtOpiekaRozpOpieki.Text.Length == 5 && maskedTxtOpiekaKonOpieki.Text.Length == 5 && txtOpiekaData.Text.Length >= 8 && txtOpiekaData.Text.Length <= 20 && comboBoxOpiekaZwierze.SelectedIndex != -1 && comboBoxOpiekaOpiekun.SelectedIndex != -1)
            {
                btnOpiekaZapisz.Enabled = true;
            }
            else
            {
                btnOpiekaZapisz.Enabled = false;
            }
        }

        private void comboBoxOpiekaZwierze_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (maskedTxtOpiekaRozpOpieki.Text.Length == 5 && maskedTxtOpiekaKonOpieki.Text.Length == 5 && txtOpiekaData.Text.Length >= 8 && txtOpiekaData.Text.Length <= 20 && comboBoxOpiekaZwierze.SelectedIndex != -1 && comboBoxOpiekaOpiekun.SelectedIndex != -1)
            {
                btnOpiekaZapisz.Enabled = true;
            }
            else
            {
                btnOpiekaZapisz.Enabled = false;
            }
        }

        private void comboBoxOpiekaOpiekun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (maskedTxtOpiekaRozpOpieki.Text.Length == 5 && maskedTxtOpiekaKonOpieki.Text.Length == 5 && txtOpiekaData.Text.Length >= 8 && txtOpiekaData.Text.Length <= 20 && comboBoxOpiekaZwierze.SelectedIndex != -1 && comboBoxOpiekaOpiekun.SelectedIndex != -1)
            {
                btnOpiekaZapisz.Enabled = true;
            }
            else
            {
                btnOpiekaZapisz.Enabled = false;
            }
        }

        private void maskedTxtOpiekaRozpOpieki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTxtOpiekaKonOpieki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
