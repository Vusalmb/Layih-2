using Layihə2.Enums;
using System;

namespace Layihə2.FullClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            do
            {
                Console.WriteLine("1. Greate Group");
                Console.WriteLine("2. Greate Students");
                Console.WriteLine("3. Edit Group");
                Console.WriteLine("4. Get All Groups");
                Console.WriteLine("5. Get All Seats");
                Console.WriteLine("6. Get All Students");
                Console.WriteLine("7. Get Group Students");
                Console.WriteLine("8. Reserve");
                Console.WriteLine("0. Exit");

                
                string selectStr = Console.ReadLine();
                bool result = int.TryParse(selectStr, out selection);

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            Menu.GreateGroupMenu();
                            break;
                        case 2:
                            Menu.GreateStudentsMenu();
                            break;
                        case 3:
                            Menu.EditGroupMenu();
                            break;
                        case 4:
                            Menu.GetGroupsMenu();
                            break;
                        case 5:
                            Menu.GetSeatsMenu();
                            break;
                        case 6:
                            Menu.GetStudentsMenu();
                            break;
                        case 7:
                            Menu.GetGroupStudentMenu();
                            break;
                        case 8:
                            Menu.ReserveMenu();
                            break;
                        default:
                            break;
                    }
                }
            } while (selection != 0);
        }
    }
}
