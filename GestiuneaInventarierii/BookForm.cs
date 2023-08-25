using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestiuneaInventarierii
{
    public partial class BookForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\OneDrive\Documente\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand(); 
        SqlDataReader dr;

        public BookForm()
        {
            InitializeComponent();
            LoadBook();
        }

        public void LoadBook()
        {
            int i = 0;
            dgvReg.Rows.Clear();
            cm = new SqlCommand("Select reg_id, datapredare,O.idechipament, C.denumechip, O.idangajat, P.numeangajat, rQ, C.Comm, D.status FROM tbRegistru AS O JOIN tbEchipament AS C ON O.idechipament = C.idechipament JOIN tbAngajati as P on O.idangajat = P.idangajat JOIN tbStatus AS D ON C.Comm = D.idStatus WHERE CONCAT (reg_id, datapredare,O.idechipament, C.denumechip, O.idangajat, P.numeangajat, rQ, C.Comm, D.status) LIKE '%" + textsearchBook.Text+ "%' ORDER BY reg_id", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvReg.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime( dr[1].ToString()).ToString("dd.MM.yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            con.Close();

            lblnrinreg.Text = i.ToString();

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            BookModuleForm BookModule = new BookModuleForm();
            BookModule.ShowDialog();
            LoadBook();
        }

        private void dgvReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvReg.Columns[e.ColumnIndex].Name;
            
            if (colName == "Delete")
            {
                if (MessageBox.Show("Ești sigur/ă că vrei să ștergi această înregistrare?", "DeleteRecord", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE from tbRegistru where reg_id like'" + dgvReg.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Înregistrarea a fost ștearsă cu succes!");

                    cm = new SqlCommand("UPDATE tbEchipament SET Qeq = (Qeq+@Qeq) WHERE idechipament LIKE '" + dgvReg.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ", con);
                    cm.Parameters.AddWithValue("@Qeq", Convert.ToInt32(dgvReg.Rows[e.RowIndex].Cells[7].Value.ToString()));

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                }
            }
            LoadBook();
        }

        private void textsearchBook_TextChanged(object sender, EventArgs e)
        {
            LoadBook();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            dgvReg.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText; // Include column headers

            /*btnExport*/
            dgvReg.SelectAll();
            DataObject copyD = dgvReg.GetClipboardContent();
            if (copyD!=null) Clipboard.SetDataObject(copyD);
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wbapp;
            Microsoft.Office.Interop.Excel.Worksheet worksheetapp;
            object miseddata = System.Reflection.Missing.Value;
            wbapp = app.Workbooks.Add(miseddata);

            worksheetapp = (Microsoft.Office.Interop.Excel.Worksheet)wbapp.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)worksheetapp.Cells[1, 1];
            xlr.Select();

            worksheetapp.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

    }
}
