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

namespace GestiuneaInventarierii
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\OneDrive\Documente\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked==false)     
                txtPass.UseSystemPasswordChar = true;
            else
                txtPass.UseSystemPasswordChar = false;                    
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
               
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try 
            {
                cm = new SqlCommand("SELECT * FROM tabelUser WHERE username=@username AND parola=@parola", con);
                cm.Parameters.AddWithValue("@username", txtName.Text);
                cm.Parameters.AddWithValue("@parola", txtPass.Text);
                con.Open();
                dr = cm.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    string user = dr["functie"].ToString();
                    if (user.Equals("admin", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Bine ai venit " + dr["numeprenume"].ToString() + "!", "ACCESS PERMIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                        MainForm main = new MainForm();
                        this.Hide();
                        main.ShowDialog();
                    }
                    else 
                    {
                        MessageBox.Show("Bine ai venit " + dr["numeprenume"].ToString() + "!", "ACCESS PERMIS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainForm2 main = new MainForm2();
                        this.Hide();
                        main.ShowDialog();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Username sau parolă incorectă!", "ACCESS REFUZAT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
