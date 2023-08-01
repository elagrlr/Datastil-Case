using DataStillCase.Entity.Models.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataStillCase.Data.Configuration.Seeds.Models.Tables
{
    public class VisitorHistorySeed : IEntityTypeConfiguration<VisitorHistory>
    {
        public void Configure(EntityTypeBuilder<VisitorHistory> builder)
        {
            builder.HasData(
                new VisitorHistory()
                {
                    Id = 1,
                    CityId = 1,
                    Date = Convert.ToDateTime("01.01.2023"),
                    VisitorCount = 100
                },
                new VisitorHistory()
                {
                    Id = 2,
                    CityId = 1,
                    Date = Convert.ToDateTime("01.01.2022"),
                    VisitorCount = 200
                },
                new VisitorHistory()
                {
                    Id = 3,
                    CityId = 1,
                    Date = Convert.ToDateTime("01.01.2021"),
                    VisitorCount = 90
                },
                new VisitorHistory()
                {
                    Id = 4,
                    CityId = 1,
                    Date = Convert.ToDateTime("01.01.2020"),
                    VisitorCount = 300
                },
                new VisitorHistory()
                {
                    Id = 5,
                    CityId = 2,
                    Date = Convert.ToDateTime("01.01.2023"),
                    VisitorCount = 200
                }, 
                new VisitorHistory()
                {
                    Id =6,
                    CityId = 2,
                    Date = Convert.ToDateTime("01.01.2022"),
                    VisitorCount = 150
                }, new VisitorHistory()
                {
                    Id = 7,
                    CityId = 2,
                    Date = Convert.ToDateTime("01.01.2021"),
                    VisitorCount = 80
                },
                new VisitorHistory()
                {
                    Id = 8,
                    CityId = 2,
                    Date = Convert.ToDateTime("01.01.2020"),
                    VisitorCount = 350
                }, 
                new VisitorHistory()
                {
                    Id =9,
                    CityId = 3,
                    Date = Convert.ToDateTime("01.01.2023"),
                    VisitorCount = 400
                }, 
                new VisitorHistory()
                {
                    Id = 10,
                    CityId = 3,
                    Date = Convert.ToDateTime("01.01.2022"),
                    VisitorCount = 200
                },
                new VisitorHistory()
                {
                    Id = 11,
                    CityId = 3,
                    Date = Convert.ToDateTime("01.01.2021"),
                    VisitorCount = 250
                }, 
                new VisitorHistory()
                {
                    Id = 12,
                    CityId = 3,
                    Date = Convert.ToDateTime("01.01.2020"),
                    VisitorCount = 450
                },
                new VisitorHistory()
                {
                    Id = 13,
                    CityId = 34,
                    Date = Convert.ToDateTime("01.01.2023"),
                    VisitorCount = 500
                },
                new VisitorHistory()
                {
                    Id = 14,
                    CityId = 34,
                    Date = Convert.ToDateTime("01.01.2022"),
                    VisitorCount = 600
                }, 
                new VisitorHistory()
                {
                    Id = 15,
                    CityId = 34,
                    Date = Convert.ToDateTime("01.01.2021"),
                    VisitorCount = 200
                },
                new VisitorHistory()
                {
                    Id = 16,
                    CityId = 34,
                    Date = Convert.ToDateTime("01.01.2020"),
                    VisitorCount = 300
                }, 
                new VisitorHistory()
                {
                    Id = 17,
                    CityId = 35,
                    Date = Convert.ToDateTime("01.01.2023"),
                    VisitorCount = 500
                }, 
                new VisitorHistory()
                {
                    Id = 18,
                    CityId = 35,
                    Date = Convert.ToDateTime("01.01.2022"),
                    VisitorCount = 250
                }, 
                new VisitorHistory()
                {
                    Id = 19,
                    CityId = 35,
                    Date = Convert.ToDateTime("01.01.2021"),
                    VisitorCount = 300
                }, 
                new VisitorHistory()
                {
                    Id = 20,
                    CityId = 35,
                    Date = Convert.ToDateTime("01.01.2020"),
                    VisitorCount = 100
                }, 
                new VisitorHistory()
                {
                    Id = 21 ,
                    CityId =42  ,
                    Date = Convert.ToDateTime("01.01.2023"),
                    VisitorCount =120  
                },
                new VisitorHistory()
                {
                    Id = 22 ,
                    CityId =42  ,
                    Date = Convert.ToDateTime("01.01.2022"),
                    VisitorCount =250
                },
                new VisitorHistory()
                {
                    Id =  23,
                    CityId = 42 ,
                    Date = Convert.ToDateTime("01.01.2021"),
                    VisitorCount =120
                },
                new VisitorHistory()
                {
                    Id = 24 ,
                    CityId =42  ,
                    Date = Convert.ToDateTime("01.01.2020"),
                    VisitorCount =230
                },
                new VisitorHistory()
                {
                    Id = 25 ,
                    CityId =  6,
                    Date = Convert.ToDateTime("01.01.2023"),
                    VisitorCount =350
                },
                new VisitorHistory()
                {
                    Id =  26,
                    CityId =  6,
                    Date = Convert.ToDateTime("01.01.2022"),
                    VisitorCount =275
                },
                new VisitorHistory()
                {
                    Id = 27 ,
                    CityId =  6,
                    Date = Convert.ToDateTime("01.01.2021"),
                    VisitorCount =450
                },
                new VisitorHistory()
                {
                    Id = 28 ,
                    CityId = 6 ,
                    Date = Convert.ToDateTime("01.01.2020"),
                    VisitorCount =500
                }
                );
        }
    }
}
