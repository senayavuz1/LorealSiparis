namespace Loreal.Entities
{
    public class Firma:BaseEntity,IEntity
    {
        public AnaFirma AnaFirma { get; set; }
        public string FirmaKodu { get; set; }
        public string FirmaAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string IletisimNo { get; set; }
        public string Email { get; set; }
        public IList<KontaktKisi> Kisiler { get; set; }
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }
        public decimal RiskLimiti { get; set; }
        public string OzelNot { get; set; }

        // bankaralara soruldugunda verilecek bilgiye istinaden
        // tutulacak istihbarat alanlari.
        // Not: Istihbarat Mit'ten gelmiyor. Bankalardan geliyor.
        public bool IstihbaratOnay { get; set; }
        public string IstihbaratNot { get; set; }
        public bool Sorunlumu { get; set; }










    }
}