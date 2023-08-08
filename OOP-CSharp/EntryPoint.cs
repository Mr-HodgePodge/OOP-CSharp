using Characters.Warriors;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(180, 90, "Good Guy");
        Warrior theBadGuy = new Warrior(170, 70, "Bad Guy");

        theGoodGuy.Greet(theBadGuy);
        theBadGuy.Greet(theGoodGuy);
    }
}