public class Disque : Article
{
    public string label { get; set; }

    public Disque(string nom, double prix, int quantite, Type type, string label)
     : base(nom, prix, quantite, type)
    {
        this.label = label;
    }

    public override double CalculateRent()
    {
        return this.prix * 0.85;
    }

    public void Ecouter()
    {
        Console.WriteLine("Écouter le disque : {0}, Label : {1}", this.nom, this.label);
    }

    public override void PublishDetails()
    {
        Console.WriteLine("Disque: Nom : {0}, Prix : {1}, Quantité : {2}, Type : {3}, Label : {4}", this.nom, this.prix, this.quantite, this.type, this.label);
    }
}