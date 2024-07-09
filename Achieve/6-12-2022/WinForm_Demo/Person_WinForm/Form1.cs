using PersonClassLibrary;

namespace Person_WinForm
{
    public partial class Form1 : Form
    {
        private List<Person> people = new();
        public Form1()
        {
            InitializeComponent();
            //btnLoad.Click += new EventHandler(DoClickLoad);
            btnLoad.Click += DoClickLoad;

            btnDouble.Click += (sender, e) =>
            {
                if (dgvPeople.CurrentRow == null) return;
                var p = dgvPeople.CurrentRow.Tag as Person;
                //MessageBox.Show(p.FullName);
                p.Age *= 2;
                
                //DataGridViewRow row = p.Tag as DataGridViewRow;
                //row.Cells["AgeCol"].Value = p.Age;
            };
        }


        private void DoClickLoad(object? sender, EventArgs e)
        {
            //MessageBox.Show("You click me!");
            string datafile = "../../../data.txt";
            if (File.Exists(datafile)==false) 
            {
                MessageBox.Show($"The data file, {datafile}, does not exist");
                return;
            }
            var lines = File.ReadAllLines(datafile);
            Person.Separator = "/";
            people.Clear();
            foreach(var line in lines)
            {
                var p = Person.Create(line);
                if (p != null ) { people.Add(p);   }
            }

            ViewPeople();
        }

        private void ViewPeople()
        {
            dgvPeople.Rows.Clear();
            foreach(var p in people)
            {
                int index =dgvPeople.Rows.Add(p.Code, p.LastName, p.FirstName, p.Gender, p.Age);
                dgvPeople.Rows[index].Tag = p;
                p.Tag = dgvPeople.Rows[index];

                p.DataModified += (sender, e) =>
                {
                    var p = sender as Person;
                    DataGridViewRow row = p.Tag as DataGridViewRow;
                    row.Cells["AgeCol"].Value = p.Age;
                };
            }
        }
    }
}