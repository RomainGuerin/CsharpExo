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

    public override void PublishDetails()
    {
        Console.WriteLine("Livre: Nom : {0}, Prix : {1}, Quantité : {2}, Type : {3}, ISBN : {4}, Nombre de pages : {5}", this.nom, this.prix, this.quantite, this.type, this.isbn, this.nbPages);
    }
}