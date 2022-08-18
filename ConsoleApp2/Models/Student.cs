using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    class Student
    {
        private string _fullname ;
        private string _groupNo;
        private int _age;
        public string FullName { get; set; }
        public string GroupNo {
            get
            {
                return _groupNo;
            }
            set
            {
                if (value.Length==4)
                {
                  

                    _groupNo = value;
                }
            }
            }
        public int Age {
            get
            {
                return _age;
            } 
            set
            {
                _age = value;
            }
                }
        public Student(string GroupNo ,string FullName, int Age)
        {
            this.GroupNo = GroupNo;
            this.FullName = FullName;
            this.Age = Age;
        }
    }
}
