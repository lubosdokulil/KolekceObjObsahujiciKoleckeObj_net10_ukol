namespace KolekceObjObsahujiciKoleckeObj_net10_ukol.Models
{
    public class Kategorie
    {
        public string NazevKategorie { get; set; } = "";
        public List<Jidlo> SeznamJidel { get; set; } = new List<Jidlo>(); //Seznam, do kterého se budou ukládat jednotlivé instance třídy Jídlo
    }
}
