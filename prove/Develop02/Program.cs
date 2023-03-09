using System;

class Program
{
    static void Main(string[] args)
    {
        // Menu
        Journal journal = new Journal();
        int menuUserinput = 0;
        List<string> menu = new List<string>
        {
            "Please select one of the following choices",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "What would you like to do? "
        };
        while (menuUserinput != 5)
        {
            foreach (string menuitem in menu)
            {
                Console.WriteLine(menuitem);
            }
        }
        menuUserinput = int.Parse(Console.ReadLine());


    }
}
