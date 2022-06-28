namespace Loreal.Entities
{
    public class KontaktKisi:BaseEntity,IEntity
    {

        public int FirmaId { get; set; }
        public Firma Firma { get; set; }
        public string Departman { get; set; }




    }
}