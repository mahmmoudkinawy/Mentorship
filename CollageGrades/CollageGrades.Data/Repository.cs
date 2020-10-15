using CollageGrades.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CollageGrades.Data
{
    public class Repository : IGradesData
    {
        private readonly List<Grades> grades;
        public Repository()
        {
            grades = new List<Grades>()
            {
                new Grades
                {
                    Id = 1 ,
                    FullName = "Amr Essam" , 
                    SettingNumber = 120 , 
                    InformationSystem = 70.5,
                    Introduction = 60.5 , 
                    Math1 = 65 , 
                    Physics = 89 , 
                    English = 90 , 
                    DescriteMath = 52.5 , 
                    Programming = 60.0 , 
                    Status = "Passed"
                },
                new Grades
                {
                    Id = 2 ,
                    FullName = "Islam Saber" ,
                    SettingNumber = 121 ,
                    InformationSystem = 60.5,
                    Introduction = 75.5 ,
                    Math1 = 50.5 ,
                    Physics = 70 ,
                    English = 63 ,
                    DescriteMath = 57.5 ,
                    Programming = 63.0 ,
                    Status = "Passed"
                },
                new Grades
                {
                    Id = 3 ,
                    FullName = "Mahmmoud Kinawy" ,
                    SettingNumber = 122 ,
                    InformationSystem = 30.5,
                    Introduction = 22.5 ,
                    Math1 = 35 ,
                    Physics = 39 ,
                    English = 2 ,
                    DescriteMath = 52.5 ,
                    Programming = 15.0 ,
                    Status = "Failed"
                },
                new Grades
                {
                    Id = 4 ,
                    FullName = "Ameen Ali" ,
                    SettingNumber = 123 ,
                    InformationSystem = 75.5,
                    Introduction = 22.5 ,
                    Math1 = 56 ,
                    Physics = 98 ,
                    English = 70 ,
                    DescriteMath = 51.5 ,
                    Programming = 35.0 ,
                    Status = "Failed"
                },
                new Grades
                {
                    Id = 5 ,
                    FullName = "Ahmed Omran" ,
                    SettingNumber = 124 ,
                    InformationSystem = 75.5,
                    Introduction = 62.5 ,
                    Math1 = 63 ,
                    Physics = 60 ,
                    English = 90 ,
                    DescriteMath = 52.5 ,
                    Programming = 60.0 ,
                    Status = "Passed"
                },
                new Grades
                {
                    Id = 6 ,
                    FullName = "Mohamed Samir" ,
                    SettingNumber = 125 ,
                    InformationSystem = 77,
                    Introduction = 66 ,
                    Math1 = 55 ,
                    Physics = 89 ,
                    English = 98 ,
                    DescriteMath = 57.5 ,
                    Programming = 69.0 ,
                    Status = "Passed"
                }
            };
        }

        public Grades Add(Grades updatedGrades)
        {
            grades.Add(updatedGrades);
            updatedGrades.Id = grades.Max(r => r.Id) + 1;
            return updatedGrades;
        }

        public int Commit()
        {
            return 0;
        }

        public Grades GetById(int id)
        {
            return grades.SingleOrDefault(r => r.Id == id);
        }

        //public IEnumerable<Grades> GetAll()
        //{
        //    return from r in grades
        //           orderby r.Id
        //           select r;
        //}

        public IEnumerable<Grades> GetByName(string name)
        {
            return from r in grades
                   where string.IsNullOrEmpty(name) || r.FullName.StartsWith(name)
                   orderby r.Id
                   select r;
        }

        public Grades Update(Grades updatedGrades)
        {
            var grade = grades.SingleOrDefault(r => r.Id == updatedGrades.Id);
            if(grade != null)
            {
                grade.FullName = updatedGrades.FullName;
                grade.SettingNumber = updatedGrades.SettingNumber;
                grade.InformationSystem = updatedGrades.InformationSystem;
                grade.Introduction = updatedGrades.Introduction;
                grade.Math1 = updatedGrades.Math1;
                grade.Physics = updatedGrades.Physics;
                grade.English = updatedGrades.English;
                grade.DescriteMath = updatedGrades.DescriteMath;
                grade.Programming = updatedGrades.Programming;
                grade.Status = updatedGrades.Status;
            }
            return grade;
        }
    }
}
