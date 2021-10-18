using Layihə2.Enums;
using Layihə2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihə2.FullClass
{
    class FullClass : IClassroom
    {
        private List<Group> _groups = new List<Group>();
        private List<Student> _students = new List<Student>();

        public List<Group> Groups { get { return _groups; } }
        public List<Student> Students { get { return _students; } }

        public string GreatGroup(int row, int column, GroupCategory category)
        {
            if (row <= 0 || column <= 0)
            {
                return "Please enter valid row or column number";
            }

            Group group = new Group(row, column, category);
            _groups.Add(group);
            return group.No;
        }

        public string GreatStudents(string name, GroupCategory category)
        {
            Student student = new Student(name,category);
            _students.Add(student);
            return student.GroupNo;
        }

        public void EditGroup(string no, string newNo)
        {
            Group existedGroup = null;

            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    existedGroup = group;
                    break;
                }
            }

            if(existedGroup == null)
            {
                Console.WriteLine($"{no} group does not exist");
                return;
            }

            foreach (Group group in Groups)
            {
                if(group.No.ToLower().Trim() == newNo.ToLower().Trim())
                {
                    Console.WriteLine($"{newNo} group already existed");
                    return;
                }
            }
            existedGroup.No = newNo.ToUpper();
            Console.WriteLine($"{no.ToUpper()} succesfully updated to {newNo.ToUpper()}");
        }

        public void GetAllGroups()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("There is no group");
                return;
            }

            foreach (Group group in _groups)
            {
                Console.WriteLine(group);
            }
        }

        public void GetAllSeats(string no)
        {
            Group group = _groups.Find(h => h.No.ToLower().Trim() == no.ToLower().Trim());
            if (group == null)
            {
                Console.WriteLine($"{no} group does not exist");
                return;
            }

            foreach (Seat seat in group.Seats)
            {
                Console.WriteLine(seat);
            }
        }

        public void GetAllStudents(string no)
        {
            if (_students.Count == 0)
            {
                Console.WriteLine("There is no student");
                return;
            }

            foreach (Student student in _students)
            {
                Console.WriteLine(student);
            }
        }

        public void GetGroupStudents(string no)
        {
            Group group = _groups.Find(h => h.No.ToLower().Trim() == no.ToLower().Trim());
            if (group == null)
            {
                Console.WriteLine($"{no} group does not exist");
                return;
            }

            foreach (Student student in group.Students)
            {
                Console.WriteLine(student);
            }
        }

        public void Reserve(string no, int row, int column)
        {
            if (string.IsNullOrEmpty(no))
            {
                Console.WriteLine("Please enter valid group No");
                return;
            }
            if (row <= 0 || column <= 0)
            {
                Console.WriteLine("Please enter valid row or column number");
                return;
            }
            Group group = _groups.Find(h => h.No.ToLower().Trim() == no.ToLower().Trim());

            if (group == null)
            {
                Console.WriteLine("There is no group you searched");
                return;
            }
            if (row > group.Seats.GetLength(0) || column > group.Seats.GetLength(1))
            {
                Console.WriteLine("Please enter valid row or column");
                return;
            }

            if (!group.Seats[row - 1, column - 1].IsFull)
            {
                group.Seats[row - 1, column - 1].IsFull = true;
                Console.WriteLine($"You succesfully reserved");
            }
            else
            {
                Console.WriteLine("This seat already reserved please choose another seat");
                Console.WriteLine();
                GetAllSeats(no);
            }
        }
    }
}
