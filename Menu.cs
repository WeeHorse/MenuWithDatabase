namespace MenuWithDatabase;

public class Menu
{
    Actions _actions;
    public Menu(Actions actions)
    {
        _actions = actions;
        PrintMenu();
    }

    private void PrintMenu()
    {
        Console.WriteLine("Choose option");
        Console.WriteLine("1. List all");
        Console.WriteLine("2. Show one");
        Console.WriteLine("3. Add one");
        Console.WriteLine("4. Update one");
        Console.WriteLine("5. Delete one");
        Console.WriteLine("9. Quit");
        AskUser();
    }

    private void AskUser()
    {
        var response = Console.ReadLine();
        if (response is not null)
        {
            switch (response)
            {
                case("1"):
                    Console.WriteLine("Listing all");
                    _actions.ListAll();
                    break;
                case("2"):
                    Console.WriteLine("Enter id to show details about one");
                    var id = Console.ReadLine();
                    if (id is not null)
                    { 
                        _actions.ShowOne(id);
                    }
                    break;
                case("3"):
                    Console.WriteLine("Enter details to add a new one");
                    break;
                case("4"):
                    Console.WriteLine("Enter id to update one");
                    break;
                case("5"):
                    Console.WriteLine("Enter id to delete one");
                    break;
                case("9"):
                    Console.WriteLine("Quitting");
                    Environment.Exit(0);
                    break;
            }

            PrintMenu();
        }
        
    }
    
}