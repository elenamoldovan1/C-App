using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneaInventarierii
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
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

        private void btnEchipament_Click_1(object sender, EventArgs e)
        {
            openChildForm(new EquipmentForm());
        }

        private void btnListaA_Click_1(object sender, EventArgs e)
        {
            openChildForm(new EmployeesForm());
        }

        private void btnCategorii_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void btnRegistru_Click_1(object sender, EventArgs e)
        {
            openChildForm(new BookForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
