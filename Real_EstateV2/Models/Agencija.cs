namespace Real_EstateV2.Models
{
    public class Agencija
    {
        public int IdAgencije { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string PIB { get; set; }
        public string Telefon { get; set; }
        public Grad? IdGrada { get; set; }

    }
}
