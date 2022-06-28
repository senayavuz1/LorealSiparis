namespace Loreal.Entities
{
    public class Tedarikci:BaseEntity,IEntity
    {
        public string TedarikciKodu { get; set; }
        public string TedarikciAdi { get; set; }
        public string IletisimNumarasi { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }





    }
}