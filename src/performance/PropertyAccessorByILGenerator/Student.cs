using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyAccessorByILGenerator
{
    public class Student
    {
        public Student()
        {
            FriendIds = new List<int>();
        }

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
            FriendIds = new List<int>();
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> FriendIds { get; set; }
    }
}
