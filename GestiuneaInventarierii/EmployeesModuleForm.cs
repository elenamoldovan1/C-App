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
    public partial class EmployeesModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\OneDrive\Documente\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        public EmployeesModuleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textIDAng.Text) ||
                    string.IsNullOrEmpty(textNAngajat.Text) ||
                    string.IsNullOrEmpty(textPhAngajat.Text) ||
                    string.IsNullOrEmpty(textemail.Text) ||
                    string.IsNullOrEmpty(textfunctie.Text))
                {
                    MessageBox.Show("Indică informațiile necesare în toate câmpurile!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Ești sigur/ă că vrei să adaugi acest angajat?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbAngajati(idangajat,numeangajat,nrtelangajat,email,Functie)VALUES(@idangajat, @numeangajat,@nrtelangajat,@email,@Functie)", con);
                    cm.Parameters.AddWithValue("@idangajat", textIDAng.Text);
                    cm.Parameters.AddWithValue("@numeangajat", textNAngajat.Text);
                    cm.Parameters.AddWithValue("@nrtelangajat", textPhAngajat.Text);
                    cm.Parameters.AddWithValue("@email", textemail.Text);
                    cm.Parameters.AddWithValue("@Functie", textfunctie.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Angajatul a fost adăugat cu succes!");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            textIDAng.Clear();
            textNAngajat.Clear();
            textPhAngajat.Clear();
            textemail.Clear();
            textfunctie.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Ești sigur/ă că vrei să modifici acest angajat?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbAngajati SET numeangajat=@numeangajat, nrtelangajat=@nrtelangajat, email=@email, Functie=@Functie WHERE idangajat LIKE '" + textIDAng.Text + "' ", con);
                    cm.Parameters.AddWithValue("@numeangajat", textNAngajat.Text);
                    cm.Parameters.AddWithValue("@nrtelangajat", textPhAngajat.Text);
                    cm.Parameters.AddWithValue("@email", textemail.Text);
                    cm.Parameters.AddWithValue("@Functie", textfunctie.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Angajatul a fost modificat cu succes!");
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
