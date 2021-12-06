using CMS.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Service.Repository.Interface
{
    public  interface StudentRepository
    {
        void insert(Student student);
        void delete(Student student);
        void update(Student student);
        List<Student> getAll();
        Student getById(long student_id);
        IQueryable<Student> getQueryable();
    }
}
