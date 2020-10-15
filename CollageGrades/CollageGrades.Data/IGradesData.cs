using CollageGrades.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollageGrades.Data
{
    public interface IGradesData
    {
        //IEnumerable<Grades> GetAll();
        IEnumerable<Grades> GetByName(string name);
        Grades GetById(int id);
        Grades Update(Grades updatedGrades);
        int Commit();
        Grades Add(Grades updatedGrades);
    }
}
