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
    public partial class EquipmentForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\OneDrive\Documente\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public EquipmentForm()
        {
            InitializeComponent();
            LoadEquipment();
        }
        public void LoadEquipment()
        {
            int i = 0;
            dgvEquip.Rows.Clear();
            cm = new SqlCommand("Select idechipament, denumechip,pretechip,dataachizitie,categechip,Qeq,O.Comm,C.status FROM tbEchipament as O Join tbStatus as C on O.Comm = C.idStatus WHERE CONCAT(idechipament, denumechip,pretechip,dataachizitie,categechip,Qeq,O.Comm,C.status) LIKE '%" + textsearch.Text+ "%'ORDER BY idechipament", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvEquip.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            EquipmentModuleForm EquipModule = new EquipmentModuleForm();
            EquipModule.btnSave.Enabled = true;
            EquipModule.btnUpdate.Enabled = false;
            EquipModule.ShowDialog();
            LoadEquipment();
        }

        private void dgvEquip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEquip.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                EquipmentModuleForm equipModule = new EquipmentModuleForm();
                equipModule.lblEchipId.Text = dgvEquip.Rows[e.RowIndex].Cells[1].Value.ToString();
                equipModule.textdenechip.Text = dgvEquip.Rows[e.RowIndex].Cells[2].Value.ToString();
                equipModule.textprice.Text = dgvEquip.Rows[e.RowIndex].Cells[3].Value.ToString();
                equipModule.dateTimePickerachiz.Text = dgvEquip.Rows[e.RowIndex].Cells[4].Value.ToString();
                equipModule.comboBCateg.Text = dgvEquip.Rows[e.RowIndex].Cells[5].Value.ToString();
                equipModule.textBoxQ.Text = dgvEquip.Rows[e.RowIndex].Cells[6].Value.ToString();
                equipModule.textBoxSt.Text = dgvEquip.Rows[e.RowIndex].Cells[7].Value.ToString();

                equipModule.btnSave.Enabled = false;
                equipModule.btnUpdate.Enabled = true;
                equipModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Ești sigur/ă că vrei să ștergi acest echipament?", "DeleteRecord", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("Delete from tbEchipament where idechipament like'" + dgvEquip.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Echipamentul a fost șters cu succes!");
                }
            }
            LoadEquipment();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            dgvEquip.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText; // Include column headers

            /*btnExport*/
            dgvEquip.SelectAll();
            DataObject copyD = dgvEquip.GetClipboardContent();
            if (copyD != null) Clipboard.SetDataObject(copyD);
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
