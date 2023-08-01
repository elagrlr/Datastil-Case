namespace DataStillCase.Entity.Models.Tables
{
    /// <summary>
    /// Her şehrin kendi detaylarını tutan nesnedir.
    /// </summary>
    public class Information : IEntity
    {
        public int Id { get; set; }
        public int CityId { get; set; }

        /// <summary>
        /// Enlem - Boylam
        /// </summary>
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        /// <summary>
        /// SEO metni
        /// </summary>
        public string? Editor { get; set; }


        public virtual City? City { get; set; }
    }
}
