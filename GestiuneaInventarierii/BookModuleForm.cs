using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestiuneaInventarierii
{
    public partial class BookModuleForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\OneDrive\Documente\dbInvApp.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        int Max = 0;
        public BookModuleForm()
        {
            InitializeComponent();
            LoadEmployee();
            LoadEquipment();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadEmployee()
        {
            int i = 0;
            dgvEmployees.Rows.Clear();
            cm = new SqlCommand("Select * from tbAngajati WHERE CONCAT (idangajat, numeangajat) LIKE '%" + textsearchBOXA.Text + "%'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvEmployees.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            con.Close();

        }

        public void LoadEquipment()
        {
            int i = 0;
            dgvEquip.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tbEchipament WHERE CONCAT (idechipament, denumechip,pretechip,dataachizitie,categechip,Qeq) LIKE '%" + textsearchBOXE.Text + "%' AND Qeq<>0", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvEquip.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[5].ToString(), dr[4].ToString(), dr[3].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void textsearchBOXA_TextChanged(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void textsearchBOXE_TextChanged(object sender, EventArgs e)
        {
            LoadEquipment();
        }

        public void NRUnitati()
        {
            cm = new SqlCommand("SELECT Qeq FROM tbEchipament WHERE idechipament ='" + textBoxIDechip.Text + "'", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Max = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDA.Text = dgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxnumeA.Text = dgvEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxIDechip.Text = dgvEquip.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxDenE.Text = dgvEquip.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTQ.Text = dgvEquip.Rows[e.RowIndex].Cells[3].Value.ToString();
            textdatach.Text = dgvEquip.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NRUnitati();

            if (Convert.ToInt16(numericUpDownQ.Value) > Max)
            {
                MessageBox.Show("Echipamentul de pe stoc a fost epuizat! Numărul de unități maxim pe stoc pentru acest produs este " + textBoxTQ.Text + "!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDownQ.Value = numericUpDownQ.Value - 1;
                return;
            }

            if (Convert.ToInt16(numericUpDownQ.Value) > 0)
            {
                int dif = Convert.ToInt16(textBoxTQ.Text) - Convert.ToInt16(numericUpDownQ.Value);
                textBoxDif.Text = dif.ToString();
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDA.Text =="")
                {
                    MessageBox.Show("Selectează angajatul căruia îi revine acest echipament!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (textBoxIDechip.Text == "")
                {
                    MessageBox.Show("Selectează echipamentul!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (numericUpDownQ.Value == 0)
                {
                    MessageBox.Show("Selectează numărul de unități care îi revine acestui angajat!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Ești sigur/ă că vrei să adaugi această înregistrare în Registru?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tbRegistru(datapredare,idechipament,idangajat,rQ)VALUES(@datapredare,@idechipament,@idangajat,@rQ)", con);
                    cm.Parameters.AddWithValue("@datapredare", DTpredareE.Value);
                    cm.Parameters.AddWithValue("@idechipament", Convert.ToInt32(textBoxIDechip.Text));
                    cm.Parameters.AddWithValue("@idangajat", Convert.ToInt32(textBoxIDA.Text));
                    cm.Parameters.AddWithValue("@rQ", Convert.ToInt32(numericUpDownQ.Value));
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Înregistrarea a fost adaugată cu succes în Registru!");

                    cm = new SqlCommand("UPDATE tbEchipament SET Qeq = (Qeq-@Qeq) WHERE idechipament LIKE '" + textBoxIDechip.Text + "' ", con);
                    cm.Parameters.AddWithValue("@Qeq", Convert.ToInt32(numericUpDownQ.Text));

                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadEquipment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Clear()
        {
            textBoxIDA.Clear();
            textBoxnumeA.Clear();

            textBoxIDechip.Clear(); ;
            textBoxDenE.Clear();
            textdatach.Clear();
            DTpredareE.Value = DateTime.Now;

            numericUpDownQ.Value = 0;
            textBoxDif.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

     }
}
