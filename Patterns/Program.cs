namespace Patterns;
class Programm
{
    static void Main()
    {
        Random random = new();

        Father father = new();

        for (int i = 0; i < 20; i++)
        {
            if (random.Next(0, 2) == 0)
            {
                father.FindOut(Mark.Two);
            }
            else
            {
                father.FindOut(Mark.Five);
            }
        }

        Console.ReadKey();
    }
}