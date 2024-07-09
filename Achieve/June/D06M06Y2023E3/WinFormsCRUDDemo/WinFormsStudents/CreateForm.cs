using EnrollLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsStudents
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
            cboGender.DataSource = System.Enum.GetValues(typeof(Genders));
            btnNew.Click += DoClickActionNew;
            DoClickActionNew(null, EventArgs.Empty);
            btnSubmit.Click += DoClickActionSubmit;
        }

        private void DoClickActionSubmit(object? sender, EventArgs e)
        {
            tslInfo.Text = "";
            string? firstName = txtFirstName.Text.Trim();
            if (firstName == "") firstName = null;
            string? lastName = txtLastName.Text.Trim();
            if (lastName=="") lastName = null;
            Genders? gender = null;
            if (cboGender.SelectedIndex >= 0) gender = (Genders)cboGender.SelectedValue;
            byte? age = null;
            if (txtAge.Text.Trim() != "")
            {
                if (byte.TryParse(txtAge.Text, out var temp) == true) age = temp;
            }
            try
            {
                var result = Helper.AddStudent(Program.Connection, new Student()
                {
                    Id = txtId.Text,
                    FirstName = firstName,
                    LastName = lastName,
                    Gender = gender,
                    Age = age
                });
                if (result != null)
                {
                    tslInfo.ForeColor = Color.DarkGreen;
                    tslInfo.Text = "Successfully created";
                }
                else
                {
                    tslInfo.ForeColor = Color.Black;
                    tslInfo.Text = "O records effected";
                }
            }
            catch(Exception ex)
            {
                tslInfo.ForeColor = Color.Red;
                tslInfo.Text = ex.Message.Substring(0,30) + "...";
                if (ex.Message.Length > 30)
                    MessageBox.Show(ex.Message, "Submittin new student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoClickActionNew(object? sender, EventArgs e)
        {
            tslInfo.Text = "";
            txtId.Text = Guid.NewGuid().ToString();
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cboGender.SelectedIndex = -1;
            txtAge.Text = "";
        }
    }
}
