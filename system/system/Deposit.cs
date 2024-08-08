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
    public partial class Deposit : Form
    {
        SqlConnection conn;
        SqlCommand command;

        String sql = "";

        public Deposit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(amount.Text == "")
            {
                MessageBox.Show("Please enter sum");
                return;
            }
            else
            {
                // Not multiple of 10
                if (Int32.Parse(amount.Text) % 10 != 0)
                {
                    MessageBox.Show("Invalid amount");
                    return;
                }
            }
           
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Specify Data source
            string cs = @"Data Source=tcp:manipulate.database.windows.net,1433;Initial Catalog=atm;Persist Security Info=False;User ID=atm;Password=Awork1hard;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            conn = new SqlConnection(cs);
            conn.Open();
            Console.WriteLine(Form1.user);
            // Update bank balance
            sql = "UPDATE dbo.atmsys SET cash = cash+"+amount.Text+" WHERE pin = "+Form1.user+";";
            command = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            MessageBox.Show("Successful Deposit");
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }


    }
}
