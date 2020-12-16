using StudentsLab;
using System;
using System.Windows.Forms;

namespace CreateReference
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


            try
            {
                var view = logic.Read(new Student { Id = controlTree.GetSelectedId() })?[0];
                MessageBox.Show("Вы хотите сформировать справку по студенту " + view.FIO + "?", "Подтвердите действие", MessageBoxButtons.YesNo);
                ComponentWord comp = new ComponentWord();
                using (var context = new Database())
                {
                    using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {                            
                            comp.SaveReference<Student>(dialog.FileName, view);
                            MessageBox.Show("Сохранение прошло успешно");
                            Close();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить отчет " + ex.Message);
            }
        }

    }
}
