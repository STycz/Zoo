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

            this.dbAction = DBActions.None;
        }

        private DBActions dbAction = DBActions.None;
        ZooDataSet.OpiekunRow _selectedRow = null;
        ZooDataSet.JedzenieRow _selectedRowJedzenie = null;

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
                dgvOpiekunowie.Columns[0].Visible = false;

                jedzenieTA.Fill(mainDataSet.Jedzenie);
                jedzenieBS.DataSource = mainDataSet.Jedzenie;
                dgvJedzenie.DataSource = jedzenieBS;
                dgvJedzenie.Columns[0].Visible = false;
                dgvJedzenie.Columns[4].HeaderText = "Magazyn";

                magazynTA.Fill(mainDataSet.Magazyn);
                magazynBS.DataSource = mainDataSet.Magazyn;
                dgvMagazyny.DataSource = magazynBS;
                dgvMagazyny.Columns[0].Visible = false;

                comboBoxJedzenieMagID.DataSource = magazynBS;
                comboBoxJedzenieMagID.DisplayMember = "Nazwa";
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
    }
}
