using System;

namespace SRP{

public class ShelveBook{
    public ShelveBook(string sector, string shelve)
    {
        this.Sector = sector;
        this.Shelve = shelve;
    }
    public string Sector { get; set; }

    public string Shelve { get; set; }

    private ArrayList lineItems = new ArrayList();
    public void CargarLibro (Book libro){
        
        this.lineItems.Add(libro);

    }
}
     
}