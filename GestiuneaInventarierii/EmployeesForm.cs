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
    public partial class EmployeesForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\OneDrive\Documente\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public EmployeesForm()
        {
            InitializeComponent();
            LoadEmployee();
        }
        public void LoadEmployee()
        {
            int i = 0;
            dgvEmployees.Rows.Clear();
            cm = new SqlCommand("Select * from tbAngajati", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvEmployees.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            EmployeesModuleForm EmployeesModule = new EmployeesModuleForm();
            EmployeesModule.btnSave.Enabled = true;
            EmployeesModule.btnUpdate.Enabled = false;
            EmployeesModule.ShowDialog();
            LoadEmployee();
        }

        private void dgvAngajati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployees.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                EmployeesModuleForm employeeModule = new EmployeesModuleForm();
                employeeModule.textIDAng.Text = dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
                employeeModule.textNAngajat.Text = dgvEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
                employeeModule.textPhAngajat.Text = dgvEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
                employeeModule.textemail.Text = dgvEmployees.Rows[e.RowIndex].Cells[4].Value.ToString();
                employeeModule.textfunctie.Text = dgvEmployees.Rows[e.RowIndex].Cells[5].Value.ToString();

                employeeModule.btnSave.Enabled = false;
                employeeModule.btnUpdate.Enabled = true;
                employeeModule.textIDAng.Enabled = false;
                employeeModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Ești sigur/ă că vrei să ștergi acest angajat?", "DeleteRecord", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("Delete from tbAngajati where idangajat like'" + dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Angajatul a fost șters cu succes!");
                }
            }
            LoadEmployee();
        }
    }
}
