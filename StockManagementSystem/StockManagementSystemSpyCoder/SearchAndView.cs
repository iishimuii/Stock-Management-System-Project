using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockManagementSystemSpyCoder
{
    public partial class SearchAndView : UserControl
    {
        string connectionString = @"Server =DESKTOP-O4TBSCE\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true ";
        private SqlConnection sqlConnection;
        public SearchAndView()
        {
            InitializeComponent();
        }

        private void SearchAndViewButton_Click(object sender, EventArgs e)
        {
            int companySearch = Convert.ToInt32(companyComboBoxSearch.SelectedValue);
            int categorySearch = Convert.ToInt32(categoryComboBoxSearch.SelectedValue);

            try
            {
                //4
                string query = @"SELECT * FROM SearchView WHERE CompanyId, CategoryId  = " + companySearch + ", "+ categorySearch +" ";
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //6
                sqlConnection.Open();
                //7
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    searchAndViewDataGridView.DataSource = dataTable;
                }
                else
                    searchAndViewDataGridView.DataSource = null;

                //8
                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
