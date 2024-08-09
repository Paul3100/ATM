using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace system
{
    public partial class Withdraw : Form
    {
        SqlConnection conn;
        SqlCommand command;

        String sql = "";
        public Withdraw()
        {
            InitializeComponent();
        }
        private void withdraw(String amount)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            // Specify Data source
            string cs = @"Data Source=tcp:manipulate.database.windows.net,1433;Initial Catalog=atm;Persist Security Info=False;User ID=atm;Password=Awork1hard;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            conn = new SqlConnection(cs);
            conn.Open();
            // Update transactions list
            String title = $"Withdrawal of £{amount}";
            sql = $"UPDATE dbo.atmsys SET transactions = CONCAT(transactions, ',{title}'), dates = CONCAT(dates,',{DateTime.Now.ToString("MM/dd/yyyy")}') WHERE pin = {Form1.user};";

            command = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }
        private bool underflow(int amount)
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
                if (Int32.Parse(dataReader["cash"].ToString()) >= amount)
                {
                    return true;
                }
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Form2.limit())
            {
                MessageBox.Show("Daily Limit Reached");
                return;
            }
            if (!underflow(10))
            {
                MessageBox.Show("Insufficient Funds");
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            // Specify Data source
            string cs = @"Data Source=tcp:manipulate.database.windows.net,1433;Initial Catalog=atm;Persist Security Info=False;User ID=atm;Password=Awork1hard;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            conn = new SqlConnection(cs);
            conn.Open();
            // Update bank balance
            sql = "UPDATE dbo.atmsys SET cash = cash-10 WHERE pin = " + Form1.user + ";";
            command = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            MessageBox.Show("Successful Withdrawal");
            Form2 form = new Form2();
            withdraw("10");
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form2.limit())
            {
                MessageBox.Show("Daily Limit Reached");
                return;
            }
            if (!underflow(20))
            {
                MessageBox.Show("Insufficient Funds");
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Specify Data source
            string cs = @"Data Source=tcp:manipulate.database.windows.net,1433;Initial Catalog=atm;Persist Security Info=False;User ID=atm;Password=Awork1hard;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            conn = new SqlConnection(cs);
            conn.Open();
            Console.WriteLine(Form1.user);
            // Update bank balance
            sql = "UPDATE dbo.atmsys SET cash = cash-20 WHERE pin = " + Form1.user + ";";
            command = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            withdraw("20");
            MessageBox.Show("Successful Withdrawal");
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form2.limit())
            {
                MessageBox.Show("Daily Limit Reached");
                return;
            }
            if (!underflow(40))
            {
                MessageBox.Show("Insufficient Funds");
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Specify Data source
            string cs = @"Data Source=tcp:manipulate.database.windows.net,1433;Initial Catalog=atm;Persist Security Info=False;User ID=atm;Password=Awork1hard;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            conn = new SqlConnection(cs);
            conn.Open();
            Console.WriteLine(Form1.user);
            // Update bank balance
            sql = "UPDATE dbo.atmsys SET cash = cash-40 WHERE pin = " + Form1.user + ";";
            command = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            withdraw("40");
            MessageBox.Show("Successful Withdrawal");
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Form2.limit())
            {
                MessageBox.Show("Daily Limit Reached");
                return;
            }
            if (!underflow(80))
            {
                MessageBox.Show("Insufficient Funds");
                return;
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            // Specify Data source
            string cs = @"Data Source=tcp:manipulate.database.windows.net,1433;Initial Catalog=atm;Persist Security Info=False;User ID=atm;Password=Awork1hard;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            conn = new SqlConnection(cs);
            conn.Open();
            Console.WriteLine(Form1.user);
            // Update bank balance
            sql = "UPDATE dbo.atmsys SET cash = cash-80 WHERE pin = " + Form1.user + ";";
            command = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            withdraw("80");
            MessageBox.Show("Successful Withdrawal");
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }
    }
}
