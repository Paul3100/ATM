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
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand command;
      
        String sql = "";

        public Form1()
        {
            InitializeComponent();
            initialise_table();
        }
        private void initialise_table()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Specify Data source
            string cs = @"Data Source=tcp:manipulate.database.windows.net,1433;Initial Catalog=atm;Persist Security Info=False;User ID=atm;Password=Awork1hard;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
            conn = new SqlConnection(cs);
            conn.Open();
            Console.WriteLine("Connected");
            // Delete prior records
            sql = "DELETE FROM dbo.atmsys;";
            command = new SqlCommand(sql, conn);
            adapter.InsertCommand = new SqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            // Initialise new pin numbers
            for (int i = 1000; i < 10000; i+=1000)
            {
                sql = "Insert into atmsys (pin,cash,transactions) values ("+i+",500, '[]' )";
                command = new SqlCommand(sql, conn);
                adapter.InsertCommand = new SqlCommand(sql, conn);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
            }

            Console.WriteLine("Records Inserted");
        }
        private bool pin_check(int pin)
        {
            SqlDataReader dataReader;
            sql = "SELECT * FROM dbo.atmsys WHERE pin="+pin+";";
            command = new SqlCommand(sql, conn);
            dataReader = command.ExecuteReader();

            // Valid Pin
            if (dataReader.HasRows)
            {
                dataReader.Close();
                return true;
            }

            else // Invalid
            {
                dataReader.Close();
                return false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pin_num = Int32.Parse(pin.Text);
                if (pin_check(pin_num))
                {
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Pin");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Pin");
            }
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
/*
 * atm
 * Awork1hard
 * manipulate.database.windows.net
 */