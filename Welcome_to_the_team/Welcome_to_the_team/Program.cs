using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_to_the_team
{
    class Program
    {
        //order is dbl salary, string address, string firstName, string lastName, int age, string emailAddress
        static List<Person> people = new List<Person>()
        { new TeamMember(150000, "25839 Maritime Circle S", "Rochelle","Toles",26,"shellytoles@yahoo.com"),
        new TeamMember (123000, "34 Segal way","Steven", "Smith", 54, "stevesmith@emailhub.com")};
        static void Main(string[] args)
        {
            whichWay();

        }

        static void whichWay()

        {
            try
            {

                Console.WriteLine("Would you like to add a person? Press 1");
                Console.WriteLine("If you want to view the list Press 2");
                Console.WriteLine("Press 3 to leave");
                int choosePath = int.Parse(Console.ReadLine());

                if (choosePath == 1)
                {
                    //add student
                    AddTeamMember();

                }
                else if (choosePath == 2)
                {// print list
                    PrintMe();

                }
                else if (choosePath == 3)
                {
                    //leave 
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please choose a real number");
                    whichWay();
                }
            }

            catch (FormatException)
            {

                Console.WriteLine("C'mon dude");
                whichWay();
            }

            void PrintMe()
            {
                foreach (Person p in people)
                {
                    Console.WriteLine(p.getList());
                    Console.WriteLine();
                }
            }

            void AddTeamMember()
            {

                Console.WriteLine("Would you like to add a person? y/n");
                string addStudinput = Console.ReadLine().ToLower();

                if (addStudinput == "yes" || addStudinput == "y")
                {
                        //order is dbl salary, string address, string firstName, string lastName, int age, string emailAddress, bool isAnAdult
                        Console.WriteLine("What is the persons first name?");
                        string studFirstNameInput = Console.ReadLine();
                        

                        Console.WriteLine($"What is the {studFirstNameInput}'s Last name?");
                        string studLastNameInput = Console.ReadLine();

                        Console.WriteLine($"What is {studFirstNameInput}\'s email address?");
                        string studEAddressInput = Console.ReadLine();

                        Console.WriteLine($"What is {studFirstNameInput}\'s address?");
                        string studAddressInput = Console.ReadLine();

                        Console.WriteLine($"What is {studFirstNameInput}\'s salary?");
                        double studSalaryInput = double.Parse(Console.ReadLine());

                        Console.WriteLine($"What is {studFirstNameInput}\'s age");
                        int studageInput = int.Parse(Console.ReadLine());

                        if (TeamMember.AreYouOldEnough(studageInput))
                        {
                            people.Add(new TeamMember(studSalaryInput, studAddressInput, studFirstNameInput, studLastNameInput, studageInput, studEAddressInput));
                            Console.WriteLine($"{studFirstNameInput} has been added successfully!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("We cannot add minors to the list, sorry\n");

                        }

                        whichWay();
                    
                }
                else if (addStudinput == "no" || addStudinput == "n")
                {
                    whichWay();
                }
                else
                {
                    Console.WriteLine("That was nonsense, again");
                    AddTeamMember();
                }

            }
            Looper();

        }
        static void Looper()
        {
            Console.WriteLine("Continue? y/n: ");
            string goAgain = Console.ReadLine().ToLower();
            if (goAgain == "yes" || goAgain == "y")
            {
                whichWay();
            }
            else if (goAgain == "no" || goAgain == "n")
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("That was pure nonsense");
                Looper();
            }
        }
    }
}
