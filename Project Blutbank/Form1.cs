using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Blutbank
{
    public partial class Form1 : Form
    {
        private OleDbConnection con;
        private List<Login> list = new List<Login>();
        Login login = new Login();
        public Form1()
        {
            InitializeComponent();
            OleDbConnectionStringBuilder conbuild = new OleDbConnectionStringBuilder();
            conbuild.Provider = "Microsoft.ACE.OLEDB.12.0";
            conbuild.DataSource = "H:/FI11/A B A P/Projekt Blutbank/Blutbank.accdb";
            con = new OleDbConnection(conbuild.ConnectionString);
        }

        private void Form_load(object sender, EventArgs e)
        { 
                
           
        }
        

        private void buttonBestätigen_Click(object sender, EventArgs e)
        {
           
         
            try
            {
                if (openConnection())
                {
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Select * from Login";
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(mkLogin(reader));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



                if (textBoxNutzername.Text.Equals(list[0].Nutzername) && textBoxPasswort.Text.Equals(list[0].Password))
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        //Admin
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.Show();
                    }
                }
                else if (textBoxNutzername.Text.Equals(list[1].Nutzername) && textBoxPasswort.Text.Equals(list[1].Password))
                {
                    if (comboBox1.SelectedIndex == 1)
                    {
                        //Personal
                        this.Hide();
                        Form3 f3 = new Form3();
                        f3.Show();
                    }
                }
               else
               {
                  MessageBox.Show("Falscher Login");   
               }

                
            con.Close();    
        }

        private Login mkLogin(OleDbDataReader reader)
        {
            Login login1 = new Login();
            int i = 0;
            login1.Id = reader.GetInt32(i++);
            login1.Nutzername = Convert.ToString(reader[i++]);
            login1.Password = Convert.ToString(reader[i++]);
            login1.Befugniss = Convert.ToString(reader[i++]);

            return login1;
        }

        private bool openConnection()
        {
            Boolean result = true;
            if (con.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    con.Open();
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}
