using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system
{
    public partial class Balance : Form
    {
        SqlConnection conn;
        SqlCommand command;

        String sql = "";
        public Balance()
        {
            InitializeComponent();
            // Update balance label
            value.Text = balance();
            value.Refresh();
        }
        private String balance()
        {
            SqlDataReader dataReader;
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Specify Data source
            string cs = @"Data Source=tcp:manipulate.database.windows.net,1433;Initial Catalog=atm;Persist Security Info=False;User ID=atm;Password=Awork1hard;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            conn = new SqlConnection(cs);
            conn.Open();
            Console.WriteLine("Connection");
            // Fetch remaining balance
            sql = "SELECT cash FROM dbo.atmsys WHERE pin = " + Form1.user + ";";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                return dataReader["cash"].ToString();
            }
            return "-1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }
    }
}
