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
    

    public partial class EquipmentModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\OneDrive\Documente\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlCommand da = new SqlCommand();
        SqlDataReader dr;
        DataSet ds;
              
        public EquipmentModuleForm()
        {
            InitializeComponent();
            LoadCategory();
            LoadComboBCom();

            ds = new DataSet();
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\lenut\\OneDrive\\Documente\\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                string query = "SELECT * FROM tbStatus";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                ds.Clear();

                try
                {
                    connection.Open();
                    adapter.Fill(ds, "tbStatus");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void LoadCategory()
        {
            comboBCateg.Items.Clear();
            cm=new SqlCommand("SELECT numecateg FROM tbCategorii", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                comboBCateg.Items.Add(dr[0].ToString());
                
            }
            dr.Close();
            con.Close();
        }

        public void LoadComboBCom()
        {
            comboBCom.Items.Clear();
            cm = new SqlCommand("SELECT * FROM tbStatus", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                String status = dr.GetString(1);
                comboBCom.Items.Add(status);
            }
            dr.Close();
            con.Close();
        }

        private void comboBCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = 0;
            int st = comboBCom.SelectedIndex;

            foreach (DataRow dr in ds.Tables["tbStatus"].Rows)
            {
                if (st >= 0 && st < ds.Tables["tbStatus"].Rows.Count)
                {
                    DataRow selectedRow = ds.Tables["tbStatus"].Rows[st];
                    textBoxSt.Text = selectedRow["idStatus"].ToString();
                    code = Convert.ToInt32(selectedRow["idStatus"]);
                }
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textdenechip.Text) ||
                   string.IsNullOrEmpty(textprice.Text) ||
                   string.IsNullOrEmpty(comboBCateg.Text) ||
                   string.IsNullOrEmpty(textBoxQ.Text) ||
                   string.IsNullOrEmpty(comboBCom.Text))
                {
                    MessageBox.Show("Indică informațiile necesare în toate câmpurile!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                    if (MessageBox.Show("Ești sigur că vrei să adaugi acest echipament?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int nrunit = Convert.ToInt32(textBoxQ.Text);
                    con.Open();

                    for (int i = 0; i < nrunit; i++)
                    {
                        cm = new SqlCommand("INSERT INTO tbEchipament(denumechip,pretechip,dataachizitie,categechip,Qeq,Comm)VALUES(@denumechip,@pretechip,@dataachizitie,@categechip,@Qeq,@Comm)", con);
                        cm.Parameters.AddWithValue("@denumechip", textdenechip.Text);
                        cm.Parameters.AddWithValue("@pretechip", Convert.ToInt16(textprice.Text));
                        cm.Parameters.AddWithValue("@dataachizitie", Convert.ToString(dateTimePickerachiz.Text));
                        cm.Parameters.AddWithValue("@categechip", comboBCateg.Text);
                        cm.Parameters.AddWithValue("@Qeq", Convert.ToInt16("1"));
                        cm.Parameters.AddWithValue("@Comm", Convert.ToInt16(textBoxSt.Text));

                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                    }
                    
                    
                    con.Close();
                    MessageBox.Show("Echipamentul a fost adăugat cu succes!");
                    Clear();
                    LoadCategory();
                    LoadComboBCom();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            textdenechip.Clear();
            textprice.Clear();
            dateTimePickerachiz.Value = DateTime.Today;
            comboBCateg.Items.Clear();
            textBoxQ.Clear();
            comboBCom.Items.Clear();
            textBoxSt.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Ești sigur/ă că vrei să modifici acest echipament?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbEchipament SET denumechip=@denumechip, pretechip=@pretechip, dataachizitie=@dataachizitie, categechip=@categechip, Qeq=@Qeq, Comm=@Comm WHERE idechipament LIKE '" + lblEchipId.Text + "' ", con);
                    cm.Parameters.AddWithValue("@denumechip", textdenechip.Text);
                    cm.Parameters.AddWithValue("@pretechip", Convert.ToInt16(textprice.Text));
                    cm.Parameters.AddWithValue("@dataachizitie", Convert.ToString(dateTimePickerachiz.Text));
                    cm.Parameters.AddWithValue("@categechip", comboBCateg.Text);
                    cm.Parameters.AddWithValue("@Qeq", Convert.ToInt16(textBoxQ.Text));
                    cm.Parameters.AddWithValue("@Comm", Convert.ToInt16(textBoxSt.Text));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Echipamentul a fost modificat cu succes!");
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
