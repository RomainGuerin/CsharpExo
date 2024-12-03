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
}