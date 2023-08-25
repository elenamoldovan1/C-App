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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //to showsubform form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btnListaA_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeesForm());
        }

        private void btnCategorii_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void btnEchipament_Click(object sender, EventArgs e)
        {
            openChildForm(new EquipmentForm());
        }

        private void btnRegistru_Click(object sender, EventArgs e)
        {
            openChildForm(new BookForm());
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
