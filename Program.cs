namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quelle année souhaites-tu véfier ?");
        int yearAnswer = Convert.ToInt32(Console.ReadLine());
        int one = yearAnswer % 400;
        int two = yearAnswer % 4;
        int three = yearAnswer % 100;
        if(one == 0)
        {
            Console.WriteLine("Ton année est Bissextile");
        }else if (two == 0)
        {
            Console.WriteLine("Ton année est bissextile");
        }else if (three == 0)
        {
            Console.WriteLine("Ton année n'est pas bissextile");
        }
        else
        {
            Console.WriteLine("Ton année n'est pas bissextile");
        }
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.

    }
}