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
            this.dbAction = DBActions.None;
            txtOpiekunImie.Focus();
        }

        private DBActions dbAction = DBActions.None;
        ZooDataSet.OpiekunRow _selectedRow = null;

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

        
    }
}
