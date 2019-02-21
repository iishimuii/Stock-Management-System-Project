using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystemSpyCoder.Models;
using System.Data.SqlClient;

namespace StockManagementSystemSpyCoder
{
    public partial class StockIn : UserControl
    {
        StocksIn stocksIn = new StocksIn();
        string connectionString = @"Server =DESKTOP-O4TBSCE\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true ";
        private SqlConnection sqlConnection;

        public StockIn()
        {
            InitializeComponent();
        }

        private void StockInSaveButton_Click(object sender, EventArgs e)
        {
            // stocksIn.Name = itemNameTextBox.Text;
            stocksIn.ItemId = Convert.ToInt32(itemStockInComboBox.SelectedValue);
            // stocksIn.CompanyId = Convert.ToInt32(companyComboBox.SelectedValue);
            int companyId = Convert.ToInt32(companyStockInComboBox.SelectedValue);
            stocksIn.Quantity = Convert.ToInt32(stockInQuantityTextBox.Text);

            // string query = @"INSERT INTO Items (CompanyId, ) VALUES ( " + companyId + ")";

            //reorderLevelTextBox.Text = "";
           // avalibleQuantityTextBox.Text = "";

            bool isSave = Add(stocksIn);

            if (isSave)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
      }
        private bool Add(StocksIn stocksIn)
        {
            bool isSucces = false;

            try
            {

                sqlConnection = new SqlConnection(connectionString);

                string query = @"INSERT INTO StockIn (ItemId, Quantity) VALUES ( " + stocksIn.ItemId + "," + stocksIn.Quantity + ")";

                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //6
                sqlConnection.Open();
                //7
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {             
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }

                //8
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            return isSucces;

        }

      
    }
}
