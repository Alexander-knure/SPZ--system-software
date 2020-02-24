using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    [Serializable]
    public class StudentList
    {
        public Dictionary<int, Student> _list;

        public StudentList()
        {
            _list = new Dictionary<int, Student>();
        }

        public void AddStudent(Student student)
        {
            _list[ student._id ] = student;
        }

        public void RemoveStudent(int ID)
        {
            _list.Remove(ID);
        }

        public void AddSubject(int ID, Subject Subject)
        {
            _list[ ID ].AddSubject( Subject );
        }

        public void RemoveSubject(int ID, string name)
        {
            _list[ ID ].RemoveSubject( name );
        }

        public void Clear()
        {
            _list.Clear();
        }

        public Student GetStudent(int ID)
        {
            return _list[ ID ];
        }

        public List<Student> GetStudents()
        {
            var students = new List<Student>();
            foreach(var item in _list)
                students.Add( item.Value );
            
            return students;
        }

        public int GetCount()
        {
            return _list.Count();
        }
    }
}
