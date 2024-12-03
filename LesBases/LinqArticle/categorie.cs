public class Poche : Livre
{
    public string categorie { get; set; }
    public Poche(string nom, double prix, int quantite, Type type, string isbn, int nbPages, string categorie)
     : base(nom, prix, quantite, type, isbn, nbPages)
    {
        this.categorie = categorie;
    }

    public override void PublishDetails()
    {
        Console.WriteLine("Livre de poche: Nom : {0}, Prix : {1}, Quantité : {2}, Type : {3}, ISBN : {4}, Nombre de pages : {5}, Catégorie : {6}", this.nom, this.prix, this.quantite, this.type, this.isbn, this.nbPages, this.categorie);
    }
}

public class Broche : Livre
{
    public string categorie { get; set; }
    public Broche(string nom, double prix, int quantite, Type type, string isbn, int nbPages, string categorie)
     : base(nom, prix, quantite, type, isbn, nbPages)
    {
        this.categorie = categorie;
    }

    public override void PublishDetails()
    {
        Console.WriteLine("Livre broché: Nom : {0}, Prix : {1}, Quantité : {2}, Type : {3}, ISBN : {4}, Nombre de pages : {5}, Catégorie : {6}", this.nom, this.prix, this.quantite, this.type, this.isbn, this.nbPages, this.categorie);
    }
}