namespace DataStillCase.Entity.Models.Tables
{
    /// <summary>
    /// Şehir bilgilerini tutan nesnedir.
    /// </summary>
    public class City : IEntity
    {
        public City()
        {
            Informations = new HashSet<Information>();
            VisitorHistories = new HashSet<VisitorHistory>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Information> Informations { get; set; }
        public virtual ICollection<VisitorHistory> VisitorHistories { get; set; }
    }
}
