using Ch10CardLib;

Deck deck = new Deck();

for (int j = 0; j < 50; j++)
{
    deck.Shuffle();

    Card[] hand = new Card[5];
    Random random = new Random();

    for (int i = 0; i < hand.Length; i++)
    {
        bool notFoundCard = true;
        while (notFoundCard)
        {
            int randomIndex = random.Next(52);
            Card card = deck.GetCard(randomIndex);
            if (!hand.Contains(card))
            {
                notFoundCard = false;
                hand[i] = card;
            }
        }
    }

    Suit suit = hand[0].suit;
    bool flush = true;
    for (int i = 1; i < hand.Length; i++)
    {
        if (suit != hand[i].suit)
        {
            flush = false;
            break;
        }
    }

    if (flush)
    {
        for (int i = 0; i < hand.Length; i++)
        {
            Console.WriteLine(hand[i].ToString());
        }
        Console.WriteLine("You got flush!");
        break;
    }
    else
    {
        Console.WriteLine("No flush!");
    }
}