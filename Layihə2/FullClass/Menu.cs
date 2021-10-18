using Layihə2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihə2.FullClass
{
    static class Menu
    {
        public static FullClass fullClass = new FullClass();

        public static void GreateGroupMenu()
        {
            Console.WriteLine("Please enter row number");
            int row;
            string rowStr = Console.ReadLine();
            bool rowResult = int.TryParse(rowStr, out row);

            Console.WriteLine("Please enter column number");
            int col;
            string colStr = Console.ReadLine();
            bool colResult = int.TryParse(colStr, out col);

            if (rowResult && colResult)
            {
                Console.WriteLine("Please choose the category you want");

                foreach (var item in Enum.GetValues(typeof(GroupCategory)))
                {
                    Console.WriteLine($"{(int)item}. {item}");
                }

                int category;
                string categoryStr = Console.ReadLine();
                bool categoryResult = int.TryParse(categoryStr, out category);

                if (categoryResult)
                {
                    switch (category)
                    {
                        case 1:
                            string No = fullClass.GreatGroup(row, col, GroupCategory.Programming);
                            Console.WriteLine($"{No} group succesfully created");
                            break;
                        case 2:
                            No = fullClass.GreatGroup(row, col, GroupCategory.Design);
                            Console.WriteLine($"{No} group succesfully created");
                            break;
                        case 3:
                            No = fullClass.GreatGroup(row, col, GroupCategory.SystemAdministration);
                            Console.WriteLine($"{No} group succesfully created");
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public static void GreateStudentsMenu()
        {
            Console.WriteLine("Please enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please choose the category you want:");
            foreach (var item in Enum.GetValues(typeof(GroupCategory)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }

            int category;
            string categoryStr = Console.ReadLine();
            bool categoryResult = int.TryParse(categoryStr, out category);

            if (categoryResult)
            {
                switch (category)
                {
                    case 1:
                        string GroupNo = fullClass.GreatStudents(name,GroupCategory.Programming);
                        Console.WriteLine($"{GroupNo} group succesfully created");
                        break;
                    case 2:
                        GroupNo = fullClass.GreatStudents(name, GroupCategory.Design);
                        Console.WriteLine($"{GroupNo} group succesfully created");
                        break;
                    case 3:
                        GroupNo = fullClass.GreatStudents(name, GroupCategory.SystemAdministration);
                        Console.WriteLine($"{GroupNo} group succesfully created");
                        break;
                    default:
                        break;
                }
            }
        }

        public static void EditGroupMenu()
        {
            Console.WriteLine("Please enter valid group no");
            string groupNo = Console.ReadLine();

            Console.WriteLine("Please enter valid new group no");
            string newGroupNo = Console.ReadLine();

            fullClass.EditGroup(groupNo, newGroupNo);
        }

        public static void GetGroupsMenu()
        {
            fullClass.GetAllGroups();
        }

        public static void GetStudentsMenu()
        {
            Console.WriteLine("Please enter student No");
            string studentNo = Console.ReadLine();
            fullClass.GetAllStudents(studentNo);
        }

        public static void GetSeatsMenu()
        {
            Console.WriteLine("Please enter group No");
            string groupNo = Console.ReadLine();
            fullClass.GetAllSeats(groupNo);
        }

        public static void GetGroupStudentMenu()
        {
            Console.WriteLine("Please enter group No");
            string groupNo = Console.ReadLine();
            fullClass.GetGroupStudents(groupNo);
        }

        public static void ReserveMenu()
        {
            fullClass.GetAllGroups();
            if (fullClass.Groups.Count != 0)
            {
                Console.WriteLine("Please choose the group No");

                string group = Console.ReadLine();

                Console.WriteLine("Please choose the row");

                int row;

                string rowStr = Console.ReadLine();

                bool resultRow = int.TryParse(rowStr, out row);

                Console.WriteLine("Please choose the col");

                int col;

                string colStr = Console.ReadLine();

                bool resultCol = int.TryParse(colStr, out col);
                if (resultCol && resultRow)
                {
                    fullClass.Reserve(group, row, col);
                }
            }
        }
    }
}
