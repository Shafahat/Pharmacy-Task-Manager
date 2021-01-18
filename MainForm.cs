using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyTaskManager
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activateForm;

        public MainForm()
        {
            InitializeComponent();
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleLbl.Text = childForm.Text;

        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(3, 168, 135);
                    currentButton.ForeColor = Color.FromArgb(255, 255, 255);
                    titleLbl.Text = currentButton.Text.ToUpper();
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if(previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(34, 39, 70);
                    previousButton.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddItemForm(), sender);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SearchMedicineForm(), sender);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
