//Valerie Aguilar
//October 25, 2022
bool playAgain = true;
bool isValid = true;
bool validNumber;
string response;
string userSelect;



string[] Restaurants = { "Nena's", "Xochimilco", "Las Palmas", "Tio Pepe's", "Arroyo's", "Casa Flores", "Las Casuelas", "El Grullense", "Don Luis", "Taco Bell", "Angelina's", "Pietro's", "Olive Garden", "The Waterloo", "De Vega Brother's", "Bella Vista", "String's", "Da'Vinci's", "Eddie's Pizza", "David's Pizza", "Denny's", "iHOP", "Cast Iron Trading", "Chick Fil A", "BJ's Restaurant and BrewHouse", "Moo Moo's", "FED", "The Kitchen at Kitchenaid", "Cast Iron" };

Random RanRest = new Random();
int choice;

while (playAgain == true)
{
    isValid = true;
    Console.WriteLine("Welcome! Please select a restaurnt category");
    Console.WriteLine("Select 1 for Mexican Food, Select 2 for Italian Food, Select 3 for American Food, or select 4 for all categories combined.");

    do
    {
        userSelect = Console.ReadLine();
        validNumber = int.TryParse(userSelect, out choice);
        if (validNumber != true || choice >= 5)
        {
            Console.Write("Please enter a valid whole number.");
        }
    }
    while (validNumber != true || choice >= 5);

    if (choice == 1)
    {
        int ranGen = RanRest.Next(0, 10);
        Console.WriteLine("Your restaurant is: " + Restaurants[ranGen]);
    }
    else if (choice == 2)
    {
        int ranGen2 = RanRest.Next(10, 20);
        Console.WriteLine("Your restaurant is: " + Restaurants[ranGen2]);
    }
    else if (choice == 3)
    {
        int ranGen3 = RanRest.Next(20, 30);
        Console.WriteLine("Your restaurant is: " + Restaurants[ranGen3]);
    }
    else if (choice == 4)
    {
        int ranGen4 = RanRest.Next(0, 30);
        Console.WriteLine("Your restaurant is: " + Restaurants[ranGen4]);
    }
    while(isValid)
    {
        Console.Write("Do you want to select again? (Y/N) ");
        response = Console.ReadLine().ToUpper();
        if(response == "Y")
            {
                playAgain = true;
                isValid = false;
            }
            else if(response == "N")
            {
                playAgain = false;
                isValid = false;
            }
            else
            {
                playAgain = false;
                isValid = true;
                Console.WriteLine(response + " isn't a valid response. Please Enter an actual valid response please.");
            }
        

    }



}








