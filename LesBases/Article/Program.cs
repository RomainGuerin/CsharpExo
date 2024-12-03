// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Article article1 = new("Article 1", 2.99, 300);
        Article article2 = new("Article 2", 7, 125);
        Article article3 = new("Article 3", 12.5, 50);

        article1.Afficher();
        article2.Afficher();
        article3.Afficher();

        article1.Ajouter(100);
        article1.Afficher();

        article2.Retirer(50);
        article2.Afficher();

        article3.Retirer(100);
        article3.Afficher();

        Console.WriteLine("Entrez le nom de l'article :");
        string nom = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrEmpty(nom))
        {
            Console.WriteLine("Le nom de l'article ne peut pas être vide.");
            return;
        }

        Console.WriteLine("Entrez le prix de l'article :");
        if (!double.TryParse(Console.ReadLine(), out double prix))
        {
            Console.WriteLine("Le prix de l'article doit être un nombre valide.");
            return;
        }

        Console.WriteLine("Entrez la quantité de l'article :");
        if (!int.TryParse(Console.ReadLine(), out int quantite))
        {
            Console.WriteLine("La quantité de l'article doit être un nombre entier valide.");
            return;
        }

        Article article4 = new(nom, prix, quantite);
        article4.Afficher();
    }
}