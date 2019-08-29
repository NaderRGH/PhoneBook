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

namespace WinFrmEF_DBFirst.ViewLayer.Category
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            CategoryBusiness pb = new CategoryBusiness();
            List<CategoryTbl> categories = pb.GetAllCategory();
            DataTable categoryData;
            if (categories != null && categories.Count > 0)
            {
                categoryData = Common.ListToDataTable(categories);
                if (categoryData != null)
                {
                    dgvCategory.DataSource = categoryData;
                }
                else
                {
                    MessageBox.Show("Some Error Occured in Convert List<T> to DataTable!");
                }
            }
            else
                MessageBox.Show("Categories table is empty!");

        }
    }
}
