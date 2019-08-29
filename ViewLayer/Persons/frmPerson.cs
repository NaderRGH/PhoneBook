using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFrmEF_DBFirst.BusinessLayer;
using WinFrmEF_DBFirst.DataAccessLayer;

namespace WinFrmEF_DBFirst.ViewLayer.Persons
{
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
        }

        private void frmPerson_Load(object sender, EventArgs e)
        {
            PersonBusiness pb = new PersonBusiness();
            List<PersonTbl> persons = pb.GetAllPersons();
            DataTable personData;
            if (persons != null && persons.Count > 0)
            {
                personData = Common.ListToDataTable(persons);
                if (personData != null)
                {
                    dgvPerson.DataSource = personData;
                }
                else
                {
                    MessageBox.Show("Some Error Occured in Convert List<T> to DataTable!");
                }
            }
            else
                MessageBox.Show("Persons table is empty!");

        }
    }
}
