// See https://aka.ms/new-console-template for more information

// Skapa en wardrobe app
// Lägga in kläder
// ta bort kläder
// skriva ut alla kläder

string[] clothes = new string[64];

clothes[0] = "Shirt";
clothes[1] = "Pants";
clothes[2] = "Tie";

bool running = true;

while(running)
{
    Console.Clear();
    Console.WriteLine("show: displays current content");
    Console.WriteLine("add: lets you add another piece of clothing");
    Console.WriteLine("quit: exits the program");

    string input = Console.ReadLine();

    switch(input)
    {
        case "add":
            Console.WriteLine("Please enter what you would like to add");
            input = Console.ReadLine();

            for(int i = 0; i < 64; i += 1)
            {
                string current = clothes[i];

                if(current == "" || current == null)
                {
                    clothes[i] = input;
                    break;
                }
            }
        break;

        case "remove":
            Console.Clear();
            for(int i = 0; i < 64; i += 1)
            {
                string current = clothes[i];
                int fake_index = i + 1;
                
                if(current != "" && current != null)
                {
                    Console.WriteLine(fake_index + ". " + current);
                }
            }
            Console.WriteLine("Please enter the index of the item you wish to remove.");
            input = Console.ReadLine();

            if(int.TryParse(input, out int selected_index) && selected_index <= 64 && selected_index > 0)
            {
                clothes[selected_index - 1] = "";
            }
            else
            {
                Console.WriteLine("Invalid index selected, press ENTER to continue...");
                Console.ReadLine();
            }
        break;

        case "show":
            Console.Clear();
            for(int i = 0; i < 64; i += 1)
            {
                string current = clothes[i];
                
                if(current != "" && current != null)
                {
                    Console.WriteLine(current);
                }
            }

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        break;

        case "quit":
            running = false;
        break;

        default:
            Console.WriteLine("Please enter a valid command...");
        break;
    }
}
