using StudentsLab;
using System;
using System.Windows.Forms;

namespace ChangeScholarshipPlugin
{
    public partial class FormMain : Form
    {
        IPlugin _plug;
        StudentLogic logic = new StudentLogic();

        public FormMain(IPlugin plug)
        {
            InitializeComponent();
            this._plug = plug;            
        }

        private void LoadData()
        {
            try
            {
                var list = logic.Read(null);
                controlTree.CreateTree(list, "Year");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
           LoadData();           
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            if (controlTree.GetSelectedItem() != null)
            {                
                int id = controlTree.GetSelectedId();
                var form = new FormStudent();
                form.Id = id;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }

            }

        }

    }
}
