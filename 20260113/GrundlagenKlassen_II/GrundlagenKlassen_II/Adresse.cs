using System;

namespace GrundlagenKlassen_II
{
    //DTO => Data Transfer Object (POCO => Plain Old CRL Object)
    public class Adresse
    {        
        public string Wohnort { get; set; }

        public int Plz { get; set; }

        public string Strasse { get; set; }
        
        //= Auto-Properties
        public string HausNr { get; set; }
    }
}
