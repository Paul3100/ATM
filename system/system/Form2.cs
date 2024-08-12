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
    public partial class Form2 : Form
    {
      
        public static string[] transactions;
        public static string[] dates;
        public Form2()
        {
            InitializeComponent();
            prevtransactions();
        }
        public static void prevtransactions()
        {
            SqlConnection conn;
            SqlCommand command;

            String sql = "";
            SqlDataReader dataReader;
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Specify Data source
            string cs = @"Data Source=tcp:manipulate.database.windows.net,1433;Initial Catalog=atm;Persist Security Info=False;User ID=atm;Password=Awork1hard;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            conn = new SqlConnection(cs);
            conn.Open();
            // Fetch remaining balance
            sql = "SELECT transactions, dates FROM dbo.atmsys WHERE pin = " + Form1.user + ";";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                char[] delimiter = new char[] { ',' };
                transactions = dataReader["transactions"].ToString().Split(delimiter);
                dates = dataReader["dates"].ToString().Split(delimiter);
            }
        }
        public static bool limit()
        {
            String today = DateTime.Now.ToString("MM/dd/yyyy");
            int limit = 0;
            prevtransactions();
            for(int i = 1;i < dates.Length;i++)
            {
                if (dates[i] == today){
                    limit++;
                    if(limit == 10)
                    {
                        // Limit reached
                        Console.WriteLine("Limit Reached");
                        return true;
                    }
                }
               
            }
            // Limit not reached
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Deposit form = new Deposit();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw form = new Withdraw();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Balance form = new Balance();
            form.Show();
            this.Close();
        }
    }
}
