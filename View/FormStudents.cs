using StudentsLab;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Students.StudentsLogic;

namespace View
{
    public partial class FormStudents : Form
    {
        StudentLogic logic = new StudentLogic();
        public FormStudents()
        {
            InitializeComponent();            
        }
        private void FormStudents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            if(controlTree.GetSelectedItem() != null)
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

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            var form = new FormStudent();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
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
        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            //if (dataGridView.SelectedRows.Count == 1)
            //{
            if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = controlTree.GetSelectedId();

                try
                {
                    logic.Delete(new Student { Id = id });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadData();
            }           
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            BackUpComponent backUp = new BackUpComponent();
            var fbd = new FolderBrowserDialog();
           // SaveFileDialog fbd = new SaveFileDialog();
            using (var context = new Database())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    backUp.SaveData(fbd.SelectedPath, context.Students.ToArray());
                    MessageBox.Show("Сохранение прошло успешно");
                }
            }
        }

        private void buttonWordReport_Click(object sender, EventArgs e)
        {
            try
            {               
                ComponentWord comp = new ComponentWord();
                using (var context = new Database())
                {
                    using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            comp.Save<Student>(dialog.FileName, context.Students.ToList<Student>(), new List<string> {"ФИО", "Курс"});
                            //backUp.SaveData(fbd.SelectedPath, context.Students.ToArray());
                            MessageBox.Show("Сохранение прошло успешно");
                        }
                    }
                }
                
                
            }
            catch (Exception ex)
            {                
               MessageBox.Show("Не удалось сохранить отчет " + ex.Message);
            }
        }

        private void buttonDiagram_Click(object sender, EventArgs e)
        {
            try
            {                
                ComponentWordHistogram comp = new ComponentWordHistogram();
               // var fbd = new FolderBrowserDialog();
                using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
                {
                    using (var context = new Database())
                    {

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            List<DiagramModel> list = new List<DiagramModel>();
                            var list1 = context.Students.GroupBy(p => p.Scholarship)
                                .Select(p => new { p.Key, Count = p.Count() })
                                 .ToDictionary(p => p.Key, p => p.Count);

                            foreach (var g in list1)
                            {
                                list.Add(new DiagramModel
                                {
                                    Scholarship = g.Key,
                                    Count = g.Value
                                });
                                
                            }

                            comp.CreateDiagram(list, "Студенты", dialog.FileName);
                            MessageBox.Show("Сохранение прошло успешно");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить диаграмму " + ex.Message);
            }
        }

        private void дополнительныеФункцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPlagin();            

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
