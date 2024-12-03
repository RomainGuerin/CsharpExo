public class Poche : Livre
{
    public string categorie { get; set; }
    public Poche(string nom, double prix, int quantite, Type type, string isbn, int nbPages, string categorie)
     : base(nom, prix, quantite, type, isbn, nbPages)
    {
        this.categorie = categorie;
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
}