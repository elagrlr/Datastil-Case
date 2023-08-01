using DataStillCase.Entity.Models.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataStillCase.Data.Configuration.Seeds.Models.Tables
{
    public class InformationSeed : IEntityTypeConfiguration<Information>
    {
        public void Configure(EntityTypeBuilder<Information> builder)
        {
            builder.HasData(
                 new Information()
                 {
                     Id = 1,
                     CityId = 1,
                     Latitude = "35-E-18",
                     Longitude = "37-N-01",
                     Editor = "Sabancı Merkez Camii, Varda(Alman) Köprüsü,Taş Köprü,Büyük Saat, Yılankale, Ulu Camii ve Külliyesi"
                 },
                new Information()
                {
                    Id = 2,
                    CityId = 2,
                    Latitude = "38-E-17",
                    Longitude = "37-N-46",
                    Editor = "Nemrut Dağı, Cendere Köprüsü,Pirin Ören Yeri Su Gözü,Gölbaşı Gölleri Tabiat Parkı "
                },
                new Information()
                {
                    Id = 3,
                    CityId = 3,
                    Latitude = "30-E-33",
                    Longitude = "38-N-45",
                    Editor = "Karahisar Kalesi,Ulu Camii,Frig Vadisi Tabiat Parkı,Başkomutan Tarihi Milli Parkı,Kocatepe  "
                },
                new Information()
                {
                    Id = 4,
                    CityId = 4,
                    Latitude = "43-E-03",
                    Longitude = "39-N-44",
                    Editor = "Ağrı Dağı,İshak Paşa Sarayı,Urartu Kalesi, Diyadin KAplıcaları,Kudret Köprüsü  "
                },
                new Information()
                {
                    Id = 5,
                    CityId = 5,
                    Latitude = "35-E-50" ,
                    Longitude = "40-N-40",
                    Editor = " II.Beyazıt Camii ve Külliyesi, Amasya Arkeoloji Müzesi, Amasya Kalesi,Boraboy Gölü Tabiat Parkı, Kral Kaya Mezarları "
                },
                new Information()
                {
                    Id = 6,
                    CityId = 6,
                    Latitude = "32-E-52",
                    Longitude = "39-N-56",
                    Editor = "Anıtkabir, Anadolu Medeniyetleri Müzesi,  I.TBMM Kurtuluş Savaşı Müzesi,Ankara Kalesi, II. TBMM Cumhuriyet Müzesi,Rahmi M. Koç Müzesi "
                },
                new Information()
                {
                    Id = 7,
                    CityId = 7,
                    Latitude = "30-E-42 ",
                    Longitude = "36-N-54",
                    Editor = "Kaleiçi,Apollon Tapınağı,Düden Şelalaesi, Kleopatra Plajı,Side Anfi Tiyatrosu "
                },
                new Information()
                {
                    Id = 8,
                    CityId = 8,
                    Latitude = "41-E-49 ",
                    Longitude = "41-N-11",
                    Editor = "Mençuna Şelalesi, Karagöl, Çifte Köprü, Borçka Tabiat Parkı, İşhan Kilisesi "
                },
                new Information()
                {
                    Id = 9,
                    CityId = 9,
                    Latitude = "27-E-51 ",
                    Longitude = "37-N-51",
                    Editor = " Dilek Yarımadası Milli Parkı, Aphrodisias Antik Kenti, Altınkum Plajı, Küçükada Kalesi, Priene Antik Kenti"
                },
                new Information()
                {
                    Id = 10,
                    CityId = 10,
                    Latitude = "27-E-52",
                    Longitude = "39-N-39",
                    Editor = "Kaz Dağları, Şeytan Sofrası, Taksiyarhis Kilisesi, Kazdağları Milli Parkı, Şahinderesi Kanyonu "
                },
                new Information()
                {
                    Id = 11,
                    CityId = 11,
                    Latitude = "29-E-59 ",
                    Longitude = "40-N-09",
                    Editor = "Ertuğrul Gazi Türbesi, Şeyh Edebali Türbesi, Dursun Fakih Türbesi,Harmankaya Kanyonu Tabiat Parkı, Küçükelmalı Tabiat Parkı "
                },
                new Information()
                {
                    Id = 12,
                    CityId = 12,
                    Latitude = "40-E-29",
                    Longitude = "38-N-53",
                    Editor = "Yüzen Ada, 33 Şehit Anıtı, Buban Bacaları "
                },
                new Information()
                {
                    Id = 13,
                    CityId = 13,
                    Latitude = "42-E-06",
                    Longitude = "38-N-22",
                    Editor = " "
                },
                new Information()
                {
                    Id = 14,
                    CityId = 14,
                    Latitude =" 31-E-37",
                    Longitude = "40-N-44",
                    Editor = "Gölcük Gölü, Abant Gölü, Yedigöller Milli Parkı, Göynük ZaferKulesi, Kartalkaya Kış Turizm Merkezi "
                },
                new Information()
                {
                    Id = 15,
                    CityId = 15,
                    Latitude = "30-E-17",
                    Longitude = "37-N-43",
                    Editor = "Sagalassos Arkeolojik Buluntular, Salda Gölü,Arkeoloji Müzesi,Kibyra Antik Kenti,İnsuyu Mağarası "
                },
                new Information()
                {
                    Id = 16,
                    CityId = 16,
                    Latitude = "29-E-04",
                    Longitude = "40-N-11",
                    Editor = "Ulu Camii, Koza Hanı, Osman Gazi ve Orhan Gazi Türbeleri, Bursa Teleferik, Cumalıkızık"
                },
                new Information()
                {
                    Id = 17,
                    CityId = 17,
                    Latitude = "26-E-24 ",
                    Longitude = "40 N 09",
                    Editor = " Truva Antik Kenti, Çanakkale Deniz Müzesi, Troya Müzesi,Conk Bayırı Mehmetçik Park Anıtı Kemalyeri Yazıtı, Kabatepe Kumsalı"
                }  ,
                new Information()
                {
                    Id = 18,
                    CityId = 18,
                    Latitude = "33-E-37 ",
                    Longitude = "40-N-36",
                    Editor = "Hazım Dağlı Tabiat Parkı, Tuz Mağarası, Çankırı Müzesi,Kırkpınar Yaylası, Bayramören Köprüsü  "
                }, new Information()
                {
                    Id = 19,
                    CityId = 19,
                    Latitude = "",
                    Longitude = "",
                    Editor = " Hattuşaş, Yazılıkaya,Alacahöyük Müzesi,Aslanlı Kapı, İncesu Kanyonu "
                },
                new Information()
                {
                    Id = 20,
                    CityId = 20,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Pamukkale Travertenleri,Gemiş Yamaç Paraşütü, Kaklık Mağarası,Kleopatra Havuzları  "
                },
                new Information()
                {
                    Id = 21,
                    CityId = 21,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Ulu Camii, Diyarbakır Surları,Hasankeyf Eski Köprüsü,Surp Giragos Kilisesi,Hasan Paşa Hanı  "
                },
                new Information()
                {
                    Id = 22,
                    CityId = 22,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Selimiye Camii, Bayezid Külliyesi ve Şifahane,KAraağaç, MEriç Köprüsü, Edirne büyük Sinagogu  "
                },
                new Information()
                {
                    Id = 23,
                    CityId = 23,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Harput Kalesi, Keban Barajı, Şefik Gül Kültür Evi, Harput Ulu Camii,Kömürhan Köprüsü  "
                },
                new Information()
                {
                    Id = 24,
                    CityId = 24,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Girlevik Şelalesi, KEmaliye Karanlık Kanyon, Ekşisu Mesire Alanı, Atatürk Portresi, Erzincan Saat Kulesi  "
                },
                new Information()
                {
                    Id = 25,
                    CityId = 25,
                    Latitude = "",
                    Longitude = "",
                    Editor = " Yakutiye Medresesi, Çifte Minareli Medrese, Tortum Şelalesi,Palandöken Dağı,Erzurum Kongre ve Milli Mücadele Müzesi "
                },
                new Information()
                {
                    Id = 26,
                    CityId = 26,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Sazaova Parkı, Yılmaz Büyükerşen Balmumu Heykeller Müzesi, Eskişehir Bilim Sanat ve Kültür Parkı,Çağdaş Cam Sanatları MErkezi, Odunpazarı Evleri  "
                },
                new Information()
                {
                    Id = 27,
                    CityId = 27,
                    Latitude = "",
                    Longitude ="",
                    Editor = "Zeugma Mozaik Müzesi, Rumkale, Gaziantep Kalesi, Gaziantep Hayvanat Bahçesi, Gaziantep Oyun ve Oyuncak Müzesi  "
                },
                new Information()
                {
                    Id = 28,
                    CityId = 28,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Giresun Kalesi, Kulakkaya Yaylası, Kuzalan Şelalesi,Kümbet Yaylası,Sis Dağı  "
                },
                new Information()
                {
                    Id = 29,
                    CityId = 29,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Tomara Şelalesi Tabiat Parkı, Karaca Cave, Limni Gölü Tabiat Parkı,Taşköprü Yaylası,İkizevler Kent Müzesi  "
                },
                new Information()
                {
                    Id = 30,
                    CityId = 30,
                    Latitude = "",
                    Longitude = "",
                    Editor = " Beyaz Şelale, Cilo Buzulları, Sat Buzul Gölleri,Tarihi Taş Evler, Meydan MEdresesi "
                },
                new Information()
                {
                    Id = 31,
                    CityId = 31,
                    Latitude = "",
                    Longitude = "",
                    Editor = " Antakya Arkeoloji Müzesi,Eski Antakya,Habib-i Neccar Camii,Titus Kaya Tüneli, St. Pierre Kilisesi "
                },
                new Information()
                {
                    Id = 32,
                    CityId = 32,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Eğirdir Gölü, Kuyucak Köyü, Süleyman Demirel Demokrasi ve Kalkınma Müzesi,Zindan Mağarası, Kızıldağ Milli Parkı  "
                },
                new Information()
                {
                    Id = 33,
                    CityId = 33,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Aynalıgöl Mağarası, Uzuncaburç Olba Antik Kenti, Mut Yerköprü Şelalesi,Kızkalesi, Alahan Manastırı   "
                },
                new Information()
                {
                    Id = 34,
                    CityId = 34,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Ayasofya Camii, Galata Kulesi, Gülhane Parkı, Dolmabahçe Sarayı, Yerebatan Sarnıcı    "
                },
                new Information()
                {
                    Id = 35,
                    CityId = 35,
                    Latitude = "",
                    Longitude = "",
                    Editor = " Kordon Boyu, Kemeraltı Çarşısı,Saat Kulesi,Tarihi Asansör,İzmir Doğal Yaşam Parkı  "
                },
                new Information()
                {
                    Id = 36,
                    CityId = 36,
                    Latitude = "",
                    Longitude = "",
                    Editor = " Ani Antik Kenti,Havariler Müzesi, Kars Kalesi,Ani Katedrali, Kafkas Cephesi Harp Tarihi Müzesi  "
                },
                new Information()
                {
                    Id = 37,
                    CityId = 37,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Hz. Pir Şeyh Şaban-i Veli Külliyesi, Ilıca Şelalesi, Nasrullah Camii,Kastamonu Kalesi,Valla Kanyonu Seyir Terası   "
                },
                new Information()
                {
                    Id = 38,
                    CityId = 38,
                    Latitude = "",
                    Longitude = "",
                    Editor = " Erciyes Dağı, Hunat Hatun Külliyesi,Soğanlı Vadisi,Kayseri Lisesi Milli Mücadele Müzesi, Mimar Sinan Evi "
                },
                new Information()
                {
                    Id = 39,
                    CityId = 39,
                    Latitude = "",
                    Longitude = "",
                    Editor = "İğneada Longoz Ormanları Milli Parkı, Dupnisa Mağarası,Atatürk Evi,Kıyıköy Çiftliği, Sokullu Mehmet Paşa Camii   "
                },
                new Information()
                {
                    Id = 40,
                    CityId = 40,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Japon Bahçesi, Cacabey MEdresesi, Kaman KAlehöyük Arkeoloji Müzesi,Ahi Evran Külliyesi ve Camii,Neşet Etraş Kültür Merkezi   "
                },
                new Information()
                {
                    Id = 41,
                    CityId = 41,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Ormanya,Gayret Gemi Müzesi,İzmit Saat Kulesi,Kocaeli Bilim Müzesi, Pembe KayalarBallıkayalar Kanyonu   "
                },
                new Information()
                {
                    Id = 42,
                    CityId = 42,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Mevlana Müzesi, Konya Tropikal Kelebek Bahçesi, Sille Köyü, Aziziye Camii, Konya Bilim Merkezi  "
                },
                new Information()
                {
                    Id = 43,
                    CityId = 43,
                    Latitude = "",
                    Longitude = "",
                    Editor = " Aizanoi Antik Kenti, Dumlupınar Şehitliği,Kütahya Kalesi, Macar Evi Müzesi,Çini Müzesi  "
                },
                new Information()
                {
                    Id = 44,
                    CityId = 44,
                    Latitude = "",
                    Longitude = "",
                    Editor = "  Şire Pazarı,Silahtar Mustafa Paşa Kervansarayı, Levent Vadisi, Malatya Beşkonaklar Etnografya Müzesi, Aslantepe Ören Yeri "
                },
                new Information()
                {
                    Id = 45,
                    CityId = 45,
                    Latitude = "",
                    Longitude = "",
                    Editor = "Spil Dağı, Aigai Antik Kenti, Manisa Müzesi,Süreyya Tabiat Parkı, Kula Peribacaları"
                }

                );
        }
    }
}
