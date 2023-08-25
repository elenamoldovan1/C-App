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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\OneDrive\Documente\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cm = new SqlCommand("Select * from tabelUser", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read()) 
            {
                i++;
                dgvUser.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.btnSave.Enabled = true;
            userModule.btnUpdate.Enabled = false;
            userModule.ShowDialog();
            LoadUser();
        }

        private void dvgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName =="Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.textUserName.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.textFullName.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.textPass.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.textPhone.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.comboBoxRole.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();

                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.textUserName.Enabled = false;
                userModule.ShowDialog();
            }
            else if (colName =="Delete")
            {
                if (MessageBox.Show("Ești sigur/ă că vrei să ștergi acest utilizator?","DeleteRecord",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("Delete from tabelUser where username like'" + dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'",con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Utilizatorul a fost șters cu succes!");
                }
            }
            LoadUser();
        }
    }
}
