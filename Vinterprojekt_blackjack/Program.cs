using System;

Console.WriteLine("Welcome to blackjack, press enter to start");
Console.ReadLine();


bet();

static void bet()
{
    int money = 10;
    int maxBet = money;
    int minBet = 1;

    int bet = 0;
    bool success = false;

    while(success != true)
    {
        Console.WriteLine("Your money: " + money + " How much would you like to bet?");
        string input = Console.ReadLine();

        success = int.TryParse(input, out bet);
    }
    
    if(success == true)
    {
        if(bet > maxBet || bet < minBet)
        {
            Console.WriteLine("You need to bet a amout of money that you have");
        }
        else if(bet <= maxBet || bet >= minBet)
        {
            Console.WriteLine("You have bet " + bet + " moneys");
        }
    }
}


deal();

static void deal()
{
    Random generator = new Random();

    Console.WriteLine("Press enter to begin");
    Console.ReadLine();

    int yourCards = 0;
    int dealersCards = 0;
    
    while(yourCards < 21 && dealersCards < 21)
    {
        yourCards = generator.Next(2,11);
        dealersCards = generator.Next(2,11);

        
        Console.WriteLine("Your cards total " + yourCards + ". Would you like to stand (s) or draw another (h)");
        string hitOrStand = Console.ReadLine();
        

    }
}


Console.ReadLine();