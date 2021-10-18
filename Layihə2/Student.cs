using Layihə2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihə2
{
    class Student
    {
        public static int count = 1;
        public string Name { get; set; }
        public GroupCategory Category { get; set; }
        public string GroupNo { get; set; }
        public bool Type { get; set; }

        public Student(string name, GroupCategory category)
        {
            switch (category)
            {
                case GroupCategory.Programming:
                    GroupNo = "P" + "-" + count;
                    break;
                case GroupCategory.Design:
                    GroupNo = "D" + "-" + count;
                    break;
                case GroupCategory.SystemAdministration:
                    GroupNo = "S" + "-" + count;
                    break;
                default:
                    break;
            }

            Category = category;
            Name = name;
            string str = Console.ReadLine();
            if (str == "yes")
            {

            }
        }

        public override string ToString()
        {
            return $"No: {GroupNo}, Category: {Category}";
        }
    }
}
