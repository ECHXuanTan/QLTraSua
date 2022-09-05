using Microsoft.Reporting.WinForms;
using QuanLyQuanTraSua.DataAccessLayer;
using QuanLyQuanTraSua.Reportings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
         

            ShowMenu();

        }

        private void ShowMenu()
        {
           using (var _dbContext = new MenuDbContext())
            {
                string query = "select o.NameOrder , ca.NameCategory , o.price from Orders as o , Category as ca where o.idCategory = ca.id order by ca.NameCategory" ;

                List<rpShowMenu> menu = _dbContext.Database.SqlQuery<rpShowMenu>(query).ToList();

                var rpDataSource = new ReportDataSource("dsMenu", menu);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rpDataSource);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
