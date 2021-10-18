using Layihə2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihə2
{
    class Group
    {
        public static int count = 1;
        public string No { get; set; }
        public GroupCategory Category { get; set; }
        public bool İsOnline { get; set; }
        public int Limit { get; set; }
        public Seat[,] Seats { get; set; }
        public Student[] Students { get; set; }

        public Group(int row, int column, GroupCategory category)
        {
            switch (category)
            {
                case GroupCategory.Programming:
                    No = "P" + "-" + count;
                    break;
                case GroupCategory.Design:
                    No = "D" + "-" + count;
                    break;
                case GroupCategory.SystemAdministration:
                    No = "S" + "-" + count;
                    break;
                default:
                    break;
            }

            Category = category;
            Seats = new Seat[row, column];
            
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Seat seat = new Seat(i + 1, j + 1);
                    Seats[i,j]= seat;
                }
            }
        }

        public override string ToString()
        {
            return $"No: {No}, Category: {Category}";
        }

        public Group(string name)
        {
            Limit = 0;
            Students = new Student[0];

            if (İsOnline)
            {
                foreach (var item in name)
                {
                    Console.WriteLine(item);
                    Limit++;
                    if (Limit == 15)
                    {
                        Console.WriteLine("Qrupda yer yoxdur");
                        break;
                    }
                }
            }
            else
            {
                foreach (var item in name)
                {
                    Console.WriteLine(item);
                    Limit++;
                    if (Limit == 10)
                    {
                        Console.WriteLine("Qrupda yer yoxdur");
                        break;
                    }
                }
            }
        }
    }
}
