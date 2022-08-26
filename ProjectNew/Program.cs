Console.WriteLine("Congratulations! Buddy, you found Donald Trump's credit card!" +
    "\n Are you happy? (\"yes\" / \"no\")");
string answer = Console.ReadLine();
Console.Clear();

if (answer == "yes")
{
    Console.WriteLine("Lucky! Now let's try to guess his pin code." +
        "\nCould this be his birthday?");
}
if (answer == "no")
{
    Console.WriteLine("WTF?! Of cooooorse you are happy!" +
        "\n Try to enter the pin code little liar!");
}
Console.WriteLine("We must going to the ATM! (Press \"Enter\")");
Console.ReadLine();
Console.Clear();

string pincode = "";
int i = 9;
while (i >= 0)
{
    Console.WriteLine("Please, enter Trump's pin code:");
    pincode = Console.ReadLine();
    if (pincode == "1946")
    {
        Console.WriteLine("Wow! You can buy hot dog!");
        Console.ReadLine();
        break;
    }
    if (pincode != "1946")
    {
        int pincodeint = 0;
        pincodeint = int.Parse(pincode);
        if (pincodeint > 1946)
        {
            Console.WriteLine("Crap! Too much! Dude, try a smaller number!");
        }
        if (pincodeint < 1946)
        {
            Console.WriteLine("Oh no! Too little! Cmon, try a more number!");
        }
        Console.WriteLine($"Strain your brain - otherwise they will block the card! " +
                   $"You have {i--} attempts left!");

    }
}
Console.Clear();

if (i < 0)
{
    Console.WriteLine("Now with this card you can cut cucumbers into a salad... loser");
}
Console.ReadLine();
