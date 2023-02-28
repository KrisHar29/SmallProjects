using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsole
{
    public class Methods
    {
                //method to ask user 1. add to list 2. remove item list 3. print list 4. exit
        //assuming only numbers are input

        public static void UIStart() 
        {
            List<string> toDoList = new List<string>();
            Console.WriteLine("Welcome to the ToDo App.");
            bool continueApp = true;
            while (continueApp)
            {
                int userOption = 0;
                userOption = AskUserOptionMainMenu();
                if (userOption == 1)
                {
                    string addToToDoList = AddToToDoList();
                    toDoList.Add(addToToDoList);
                }
                if (userOption == 2)
                {
                    RemoveFromToDoList(toDoList);
                }
                if (userOption == 3)
                {
                    Console.Clear();
                    PrintToDo(toDoList);
                    Console.WriteLine("Press enter to return to menu");
                    Console.ReadLine();
                }
                if (userOption == 4) { continueApp= false; }
            }
            
            Console.ReadLine();

        }

        public static int AskUserOptionMainMenu()
        {
            Console.WriteLine("Please Make your selection (number).");
            Console.WriteLine("1 Add to ToDo list");
            Console.WriteLine("2 Remove a to do from ToDo list");
            Console.WriteLine("3 Print current ToDo list");
            Console.WriteLine("4 Exit application");
            Console.Write("Enter your selection: ");
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public static string AddToToDoList()
        {
            Console.WriteLine("Enter a to do item;");
            Console.Write("- ");
            string addToOutput = Console.ReadLine();
            Console.Clear();
            return addToOutput;
        }

        public static void RemoveFromToDoList(List<string> toDoList)
        {
            Console.WriteLine("Which line do you want to delete?");
            PrintToDo(toDoList);
            Console.Write("Line: ");
            int removeAt = int.Parse(Console.ReadLine()) -1;

            toDoList.Remove(toDoList[removeAt]);
        }

        public static void PrintToDo(List<string> toDoList)
        {
            Console.WriteLine("This is the to do list:");
            foreach (string n in toDoList)
            {
                Console.WriteLine(n);
            }
            
        }

        //public string 

        //public 
    }
}
