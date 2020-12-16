using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLab
{
    public class StudentLogic
    {
        public void CreateOrUpdate(Student model)
        {
            using (var context = new Database())
            {
                Student element = context.Students.FirstOrDefault(rec =>
               rec.FIO == model.FIO && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть студент с таким ФИО");
                }
                if (model.Id.HasValue)
                {
                    element = context.Students.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Student();
                    context.Students.Add(element);
                }
                element.FIO = model.FIO;
                element.Year = model.Year;
                element.Scholarship = model.Scholarship;
                context.SaveChanges();
            }
        }
        public void ChangeCourse(Student model)
        {
            using (var context = new Database())
            {                
                Student element = context.Students.FirstOrDefault(rec => rec.Id ==
                model.Id);
                if (element == null)
                {
                    throw new Exception("Студент не найден");
                }            
                element.Year = model.Year;                
                context.SaveChanges();
            }
        }

        public void Delete(Student model)
        {
            using (var context = new Database())
            {
                Student element = context.Students.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Students.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<Student> Read(Student model)
        {
            using (var context = new Database())
            {
                return context.Students
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new Student
                {
                    Id = rec.Id,
                    FIO = rec.FIO,
                    Year = rec.Year,
                    Scholarship = rec.Scholarship
                })
                .ToList();
            }
        }
    }
}
