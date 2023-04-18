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
            comboBoxJedzenieRodzaj.Text = "";
            comboBoxJedzenieMagID.Text = "";

            txtKlatkaNazwa.Text = "";
            txtKlatkaWysokosc.Text = "";
            txtKlatkaSzerokosc.Text = "";
            txtKlatkaGlebokosc.Text = "";
            comboBoxKlatkaSektor.Text = "";
            comboBoxKlatkaOpiekun.Text = "";

            this.dbAction = DBActions.None;
        }

        private DBActions dbAction = DBActions.None;
        ZooDataSet.OpiekunRow _selectedRow = null;
        ZooDataSet.JedzenieRow _selectedRowJedzenie = null;
        ZooDataSet.Klatka_zwierzeciaRow _selectedRowKlatka = null;

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
    }
}
