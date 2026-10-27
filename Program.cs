namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.
        Console.WriteLine("==== Convertisseur Temperatures ====");
        Console.WriteLine("1. De Celsius à Fahrenheit");
        Console.WriteLine("2. De Fahrenheit à Celsius");
        Console.Write("> Entrez Votre Choix ( 1 ou 2) : ");
        int choix = Convert.ToInt32(Console.ReadLine());

        if (choix == 1)
        {
            Console.Write(">Entrez une température en degrés Celsius, sans préciser l'unité ( ex = 19,5) : "); 
            float temp = Convert.ToSingle(Console.ReadLine());
            temp = (temp * (9f/5f) ) + 32f;
            Console.WriteLine("Votre température vaut " + temp + " degrés Fahrenheit" );
        }
        else if (choix ==2)
        {
            Console.Write(">Entrez une température en degrés Fahrenheit, sans préciser l'unité ( ex = 19,5) : ");
            float temp = Convert.ToSingle(Console.ReadLine());
            temp = (temp - 32f ) * (5f/9f);
            Console.WriteLine("Votre température vaut " + temp + " degrés Celsius" );
        }
        Console.WriteLine("Merci d'avoir utilisé notre convertisseur");
    }
}