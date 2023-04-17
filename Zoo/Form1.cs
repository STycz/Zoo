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
        public Form1()
        {
            InitializeComponent();
            //LOADING
            //1. fill data set
            opiekunTA.Fill(mainDataSet.Opiekun);
            //2. add datasource to binding source
            opiekunBS.DataSource = mainDataSet.Opiekun;
            //3. set datagridview source
            dgvOpiekunowie.DataSource = opiekunBS;

        }

        private void btnOpiekunDodaj_Click(object sender, EventArgs e)
        {
            
        }
    }
}
