using System;
namespace JournalApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

            string choice = "";
            while (choice != "5")
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");
                Console.Write("Select an option from the menu: ");
                choice = Console.ReadLine();

                if (choice =="1")
                {
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string entryText = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();

                    Entry newEntry =new Entry(date, prompt, entryText);
                    myJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added succesfully !\n");
                }
                else if (choice =="2")
                {
                    Console.WriteLine("\n--- Journal Entries ---");
                    myJournal.DisplayAll();
                    Console.WriteLine("-----------------------\n");
                }
                else if (choice == "3")
                {
                    Console.Write("\nEnter filename to save (e.g., myJournal.txt) : ");
                    string filename =Console.ReadLine();
                    myJournal.SaveToFile(filename);
                    Console.WriteLine("Journal saved successfully!\n");

                }
                else if (choice == "4")
                {
                    Console.Write("\nEnter filename to load from: ");
                    string filename = Console.ReadLine();
                    myJournal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded successfully!\n");

                }
            }
            Console.WriteLine("Goodbye!.");
        }
    }    
}    
