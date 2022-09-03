using System;

namespace SRP
{
    public class Location
    {
        public Location(string sector, string shelve)
        {
            this.Sector = sector;
            this.Shelve = shelve;
        }
        
        public string Sector { get; set; }
        public string Shelve { get; set; }
    }
}
