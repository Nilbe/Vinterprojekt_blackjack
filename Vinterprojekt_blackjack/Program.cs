using System;

//start
Console.WriteLine("Welcome to blackjack, press enter to start");
Console.ReadLine();


bet();
Console.ReadLine();

//håller koll på hur mycket man betar
static void bet()
{
    int money = 10;
    int maxBet = money;
    int bet = 0;
    bool success = false;

    while(success != true)
    {
        Console.WriteLine("Your money: " + money + " How much would you like to bet?");
        string input = Console.ReadLine();

        success = int.TryParse(input, out bet);
    

    if(success == true)
    {
        if(bet <= maxBet && bet >= 1)
        {
            Console.WriteLine("You have bet " + bet + " moneys");
        }
        else
        {
            Console.WriteLine("You need to bet a amout of money that you have");
        }
    }
    }
}



    //efter man betat så kommer spelet att börja och man slumpar fram kort

        Console.WriteLine("Press enter to begin");
        Console.ReadLine();

        Random generator = new Random();

        int yourCards = 0;
        int dealersCards = 0;
        int yourCardsDrawn;
        int dealersCardsDrawn;
    
    while(yourCards < 21 && dealersCards < 21)
    {
        Console.WriteLine("Your cards total " + yourCards + ". Would you like to stand (s) or draw another (h)");
        string hitOrStand = Console.ReadLine();
        
        hitOrStand = hitOrStand.ToLower();
            
        if(hitOrStand == "h")
        {
            yourCardsDrawn = generator.Next(2,11);
            dealersCardsDrawn = generator.Next(2,11);

            yourCards = yourCards + yourCardsDrawn;
            dealersCards = dealersCards + dealersCardsDrawn;
        }
        else if(hitOrStand == "s")
        {
            Console.WriteLine("You stand on " + yourCards);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Hit (h) or stand (s)");
        } 
    }
    if(yourCards > 21)
    {
        Console.WriteLine("You LOSE!");
    }
    else if(dealersCards > 21)
    {
        Console.WriteLine("Dealer LOST!");
    }

Console.ReadLine();