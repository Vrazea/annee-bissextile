namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.WriteLine("Quelle année souhaites-tu vérifier ?"); 
        int yearAnswer = Convert.ToInt32(Console.ReadLine()); 
        if ((yearAnswer % 4 == 0 && yearAnswer % 100 != 0) || (yearAnswer % 400 == 0)) //utilisé l'IA pour corriger cette ligne
        {
            Console.WriteLine("{yearAnswer} est une année bissextile !");
        }
        else 
        {
            Console.WriteLine("{yearAnswer} n'est pas une année bissextile.");
        }
        
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.

    }
}