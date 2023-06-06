using EnrollLibrary;
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

namespace WinFormsStudents
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            foreach(DataGridViewColumn col in dgvStus.Columns)
            {
                if (col!=delCol) col.ReadOnly = true;
            }
            btnReload.Click += DoClickActionReload;
            //DoClickActionReload(null, EventArgs.Empty);
            Helper.Added += DoOnAdded;
            Helper.Deleted += DoOnDeleted;
            Helper.Updated += DoOnUpdated;
            btnCreate.Click += (sender, e) => { (new CreateForm()).Show(); };
            btnDelete.Click += DoClickActionDelete;
            btnEdit.Click += DoClickActionEdit;
        }

        
        private void DoClickActionEdit(object? sender, EventArgs e)
        {
            if (dgvStus.CurrentRow == null) return;
            var id = (dgvStus.CurrentRow.Tag as Student)?.Id;
            (new EditForm(id!)).Show(); 
        }

        private void DoClickActionDelete(object? sender, EventArgs e)
        {
            var delStus = GetDeletedStudents().ToList();
            if (delStus.Count == 0)
            {
                MessageBox.Show("No students were selected to be deleted");
                return;
            }
            var ids = delStus.Select(x=>x.Id).ToList();
            try
            {
                if (ids.Count == 1)
                {
                    var result = Helper.DeleteStudent(Program.Connection, ids[0]);
                }
                else
                {
                    var result = Helper.DeleteStudents(Program.Connection, ids);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete selected students > {ex.Message}");
                throw;
            }
            
        }

        private void DoClickActionReload(object? sender, EventArgs e)
        {
            dgvStus.Rows.Clear();
            foreach (var stu in Helper.GetAllStudents(Program.Connection))
            {
                int index = dgvStus.Rows.Add(stu.Id, stu.FirstName, stu.LastName, stu.Gender, stu.Age);
                dgvStus.Rows[index].Tag = stu;
            }
        }
        private IEnumerable<Student> GetDeletedStudents()
        {
            if (dgvStus.Rows.Count == 0) new Student();
            foreach(DataGridViewRow row in dgvStus.Rows)
            {
                if (((bool?)row.Cells[delCol.Name].Value) == true)
                {
                    yield return (Student)row.Tag!;
                }
            }
        }

        private void DoOnAdded(object? sender, EntityEventArgs e)
        {
            if (e.Entity == EntityTypes.Students && e.Id!=null)
            {
                try
                {
                    var result = Helper.GetStudentById(Program.Connection, e.Id);
                    if (result != null)
                    {
                        int index = dgvStus.Rows.Add(result.Id, result.FirstName, result.LastName, result.Gender, result.Age);
                        dgvStus.Rows[index].Tag = result;
                    }
                }
                catch(Exception )
                {

                }
            }
        }
        private void DoOnDeleted(object? sender, EntityEventArgs e)
        {
            if (e.Entity == EntityTypes.Students)
            {
                DoClickActionReload(null, EventArgs.Empty);
            }
        }

        private void DoOnUpdated(object? sender, EntityEventArgs e)
        {
            if (e.Entity == EntityTypes.Students && e.Id != null)
            {
                try
                {
                    var result = Helper.GetStudentById(Program.Connection, e.Id);
                    if (result != null)
                    {
                        foreach (DataGridViewRow row in dgvStus.Rows)
                        {
                            if ((row.Tag as Student)?.Id == result.Id)
                            {
                                row.SetValues(result.Id, result.FirstName, result.LastName, result.Gender, result.Age);
                            }
                        }
                    }
                }
                catch (Exception )
                {

                }
            }
        }


    }
}
