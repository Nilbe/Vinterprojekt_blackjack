using System;


Console.WriteLine("Welcome to blackjack, press enter to start");
Console.ReadLine();


bet();

static void bet()
{
    int money = 10;
    int maxBet = money;
    int minBet = 1;

    bool success = false;
    int outcome;

    while(success != true)
    {
        Console.WriteLine("Your money: " + money + " How much would you like to bet?");
        string bet = Console.ReadLine();

        success = int.TryParse(bet, out outcome);
    }

    if(success == true)
    {
        if(outcome > maxBet || outcome < minBet)
        {
            Console.WriteLine("You need to bet a amout of money that you have");
        }
        else
        {
            Console.WriteLine("You have bet " + outcome + " moneys");
        }
    }
}


Console.ReadLine();