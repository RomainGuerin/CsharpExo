class Program
{
    static void Main(string[] args)
    {
        ArticleType article1 = new("Article 1", 2.99, 300, ArticleType.Type.Alimentaire);
        ArticleType article2 = new("Article 2", 7, 125, ArticleType.Type.Droguerie);
        ArticleType article3 = new("Article 3", 12.5, 50, ArticleType.Type.Habillement);

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

        Console.WriteLine("Entrez le type de l'article (Alimentaire, Droguerie, Habillement, Loisir, Autre) :");
        if (!Enum.TryParse<ArticleType.Type>(Console.ReadLine(), out ArticleType.Type type))
        {
            Console.WriteLine("Le type de l'article doit être un type valide.");
            return;
        }

        ArticleType article4 = new(nom, prix, quantite, type);
        article4.Afficher();
    }
}