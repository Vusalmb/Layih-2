using Layihə2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihə2.Interfaces
{
    interface IClassroom
    {
        public List<Group> Groups { get; }
        public List<Student> Students { get; }

        string GreatGroup(int row, int column, GroupCategory category);
        string GreatStudents(string name, GroupCategory category);
        void EditGroup(string no, string newno);
        void GetAllGroups();
        void GetAllSeats(string no);
        void GetAllStudents(string no);
        void GetGroupStudents(string no);
    }
}
