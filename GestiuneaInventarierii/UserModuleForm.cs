using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestiuneaInventarierii
{
    public partial class UserModuleForm : Form
    {

        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\OneDrive\Documente\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textUserName.Text) ||
                   string.IsNullOrEmpty(textFullName.Text) ||
                   string.IsNullOrEmpty(textPass.Text) ||
                   string.IsNullOrEmpty(textPhone.Text) ||
                    string.IsNullOrEmpty(comboBoxRole.Text))
                {
                    MessageBox.Show("Indică informațiile necesare în toate câmpurile!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Ești sigur/ă că vrei să adaugi acest utilizator?","Saving Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tabelUser(username,numeprenume,parola,nrtelefon,functie)VALUES(@username,@numeprenume,@parola,@nrtelefon,@functie)", con);
                    cm.Parameters.AddWithValue("@username", textUserName.Text);
                    cm.Parameters.AddWithValue("@numeprenume", textFullName.Text); 
                    cm.Parameters.AddWithValue("@parola", textPass.Text);
                    cm.Parameters.AddWithValue("@nrtelefon", textPhone.Text);
                    cm.Parameters.AddWithValue("@functie", comboBoxRole.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Utilizatorul a fost adăugat cu succes!");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
;        }

        public void Clear()
        {
            textUserName.Clear();
            textFullName.Clear();
            textPass.Clear();
            textPhone.Clear();
            comboBoxRole.Items.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Ești sigur/ă că vrei să modifici acest utilizator?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tabelUser SET numeprenume=@numeprenume, parola=@parola, nrtelefon=@nrtelefon, functie=@functie WHERE username LIKE '"+textUserName.Text+"' ", con);
                    cm.Parameters.AddWithValue("@numeprenume", textFullName.Text);
                    cm.Parameters.AddWithValue("@parola", textPass.Text);
                    cm.Parameters.AddWithValue("@nrtelefon", textPhone.Text);
                    cm.Parameters.AddWithValue("@functie", comboBoxRole.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Utilizatorul a fost modificat cu succes!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
