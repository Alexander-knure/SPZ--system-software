using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    [Serializable]
    public class Student
    {
        public string _name { get; set; }
        public string _surname { get; set; }
        public int _id { get;  set; }
        public Dictionary<string, Subject> _subjects;

        public Student(string Name, string Surname, int ID)
        {
            if (
                    Name == null
                ||  Name == ""
                ||  Name.Any(c => char.IsDigit(c))

                ||  Surname == null
                ||  Surname == ""
                ||  Surname.Any(c => char.IsDigit(c))
            )
            {
                throw new ArgumentException();
            }

            _subjects = new Dictionary<string, Subject>();

            _name = Name;
            _surname = Surname;
            _id = ID;
        }

        public void AddSubject(Subject Subject)
        {
            _subjects[ Subject._name ] = Subject;
        }

        public void RemoveSubject(string name)
        {
            _subjects.Remove(name);
        }

        public Subject GetSubject(string name)
        {
            return _subjects[ name ];
        }

        public void SetSubject(string key, string value)
        {
            _subjects[key]._name = value;
        }

        public List<Subject> GetSubjects()
        {
            var subjects = new List<Subject>();

            foreach (var item in _subjects)
            {
                subjects.Add( item.Value );
            }

            return subjects;
        }
    }
}
