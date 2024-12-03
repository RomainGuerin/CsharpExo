public class Livre : Article
{
    public string isbn { get; set; }
    public int nbPages { get; set; }
    public Livre(string nom, double prix, int quantite, Type type, string isbn, int nbPages)
     : base(nom, prix, quantite, type)
    {
        this.isbn = isbn;
        this.nbPages = nbPages;
    }

    public override double CalculateRent()
    {
        return this.prix * 0.9;
    }
}