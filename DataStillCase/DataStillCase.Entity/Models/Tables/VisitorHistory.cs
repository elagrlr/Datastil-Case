using System.ComponentModel.DataAnnotations;

namespace DataStillCase.Entity.Models.Tables
{
    /// <summary>
    /// Her şehrin günlük ziyaretçi sayısı
    /// </summary>
    public class VisitorHistory : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int CityId { get; set; }

        public DateTime Date { get; set; }
        public int VisitorCount { get; set; }

        public virtual City? City { get; set; }
    }
}
