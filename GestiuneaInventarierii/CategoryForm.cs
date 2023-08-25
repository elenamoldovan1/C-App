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
    public partial class CategoryForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\OneDrive\Documente\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CategoryForm()
        {
            InitializeComponent();
            LoadCategory();
        }
        public void LoadCategory()
        {
            int i = 0;
            dgvCategorii.Rows.Clear();
            cm = new SqlCommand("Select * from tbCategorii", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCategorii.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            CategoryModuleForm CategModule = new CategoryModuleForm();
            CategModule.btnSave.Enabled = true;
            CategModule.btnUpdate.Enabled = false;
            CategModule.ShowDialog();
            LoadCategory();
        }

        private void dgvCategorii_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCategorii.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CategoryModuleForm categModule = new CategoryModuleForm();
                categModule.lblCatId.Text = dgvCategorii.Rows[e.RowIndex].Cells[1].Value.ToString();
                categModule.textNCateg.Text = dgvCategorii.Rows[e.RowIndex].Cells[2].Value.ToString();
                
                categModule.btnSave.Enabled = false;
                categModule.btnUpdate.Enabled = true;
                categModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Ești sigur/ă că vrei să ștergi această categorie?", "DeleteRecord", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("Delete from tbCategorii where idcateg like'" + dgvCategorii.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Categoria a fost ștearsă cu succes!");
                }
            }
            LoadCategory();
        }
    }
}
