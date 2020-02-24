using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    [Serializable]
    public class Subject
    {
        public string _name { get; set; }
        public int _mark { get; set; }

        public Subject(string name, int Mark)
        {
            if ( 
                    name == null 
                ||  name == "" 
                ||  name.Any( c => char.IsDigit(c) )
                ||  Mark < 0
                ||  Mark > 100
            )
            {
                throw new ArgumentException();
            }

            _name = name;
            _mark = Mark;
        }
    }
}
