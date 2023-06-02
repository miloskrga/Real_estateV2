using Real_EstateV2.Models.Enums;

namespace Real_EstateV2.Models
{
    public class Nekretnine
    {
        public int IdNekretnine { get; set; }
        public string Naziv { get; set; }
        public float Kvadratura { get; set; }
        public float BrojSoba { get; set; }
        public int Spratnost { get; set; }
        public int UkupnaSpratnost { get; set; }
        public float Cena { get; set; }
        public string Opis { get; set; }
        public string Saobracaj { get; set; }
        public string Prodato { get; set; }
        public int IdKorisnika { get; set; }
        public int IdTipGrejanja { get; set; }
        public int IdTipStanja { get; set; }
        public Role_estate_Type IdTipNekretnine { get; set; }
        public int IdUlice { get; set; }
        public int IdMikrolokacije { get; set; }
        public int IdOpstine { get; set; }
        public int IdGrada { get; set; }









    }
}
