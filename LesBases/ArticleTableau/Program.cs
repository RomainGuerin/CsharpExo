class Program
{
    static void Main(string[] args)
    {
        Article[] articles = new Article[3];
        articles[0] = new Article("Article 1", 2.99, 300, Article.Type.Alimentaire);
        articles[1] = new Article("Article 2", 7, 125, Article.Type.Droguerie);
        articles[2] = new Article("Article 3", 12.5, 50, Article.Type.Habillement);

        foreach (var article in articles)
        {
            article.Afficher();
        }

        articles[0].Ajouter(100);
        articles[1].Retirer(50);
        articles[2].Retirer(100);

        foreach (var article in articles)
        {
            article.Afficher();
        }
    }
}