using Real_EstateV2.Models.Enums;

namespace Real_EstateV2.Models
{
    public class Korisnik
    {
        public int IdKorisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public Role IdTipKorisnika { get; set; } 
        public Agencija IdAgencije { get; set; }
        public string NazivGrada { get; set; }








    }
}
