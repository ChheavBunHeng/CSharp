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
    public partial class EditForm : Form
    {
        private bool idChanged = false;
        public EditForm(string id)
        {
            InitializeComponent();
            tslInfo.Text = "";
            cboGender.DataSource = System.Enum.GetValues(typeof(Genders));
            txtId.Leave += DoOnIdLeave;
            txtId.TextChanged += DoOnIdChanged;
            txtId.Text = id;
            idChanged = true;
            DoOnIdLeave(null, EventArgs.Empty);
            btnSubmit.Click += DoClickActionSubmit;
        }

        private void DoClickActionSubmit(object? sender, EventArgs e)
        {
            byte? age = null;
            if (byte.TryParse(txtAge.Text, out var temp) == true) age = temp;
            var stu = new Student()
            {
                Id = txtId.Text.Trim(),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Gender = (Genders?)cboGender.SelectedValue,
                Age = age
            };
            try
            {
                var result = Helper.UpdateStudent(Program.Connection, stu);
                if (result == true)
                {
                    tslInfo.ForeColor = Color.DarkGreen;
                    tslInfo.Text = "Successfully updated";
                }
                else
                {
                    tslInfo.ForeColor = Color.Black;
                    tslInfo.Text = "0 records effected";
                }
            }
            catch(Exception ex)
            {
                var mgs = ex.Message.Substring(0, 30) + "...";
                tslInfo.ForeColor = Color.DarkGreen;
                tslInfo.Text = mgs;
                if (ex.Message.Length > 30)
                {
                    MessageBox.Show(ex.Message, "Updating student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DoOnIdChanged(object? sender, EventArgs e)
        {
            idChanged = txtId.Text.Equals(txtId.Tag) == false;
        }

        private void DoOnIdLeave(object? sender, EventArgs e)
        {
            if (idChanged == false) return;
            try
            {
                var result = Helper.GetStudentById(Program.Connection, txtId.Text.Trim());
                if (result != null)
                {
                    txtFirstName.Text = result.FirstName;
                    txtLastName.Text = result.LastName;
                    cboGender.SelectedItem = result.Gender;
                    txtAge.Text = result.Age.ToString();

                    txtId.Tag = txtId.Text;
                    idChanged = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, $"Try to get a student with id, {txtId.Text.Trim()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
