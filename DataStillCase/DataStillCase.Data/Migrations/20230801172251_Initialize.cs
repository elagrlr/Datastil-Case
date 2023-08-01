using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataStillCase.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "CITIES",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CITIES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "INFORMATIONS",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Editor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INFORMATIONS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INFORMATIONS_CITIES_CityId",
                        column: x => x.CityId,
                        principalSchema: "dbo",
                        principalTable: "CITIES",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VISITORHISTORIES",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    VisitorCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VISITORHISTORIES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VISITORHISTORIES_CITIES_CityId",
                        column: x => x.CityId,
                        principalSchema: "dbo",
                        principalTable: "CITIES",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "CITIES",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Adana" },
                    { 2, "Adıyaman" },
                    { 3, "Afyonkarahisar" },
                    { 4, "Ağrı" },
                    { 5, "Amasya" },
                    { 6, "Ankara" },
                    { 7, "Antalya" },
                    { 8, "Artvin" },
                    { 9, "Aydın" },
                    { 10, "Balıkesir" },
                    { 11, "Bilecik" },
                    { 12, "Bingöl" },
                    { 13, "Bitlis" },
                    { 14, "Bolu" },
                    { 15, "Burdur" },
                    { 16, "Bursa" },
                    { 17, "Çanakkale" },
                    { 18, "Çankırı" },
                    { 19, "Çorum" },
                    { 20, "Denizli" },
                    { 21, "Diyarbakır" },
                    { 22, "Edirne" },
                    { 23, "Elazığ" },
                    { 24, "Erzincan" },
                    { 25, "Erzurum" },
                    { 26, "Eskişehir" },
                    { 27, "Gaziantep" },
                    { 28, "Giresun" },
                    { 29, "Gümüşhane" },
                    { 30, "Hakkari" },
                    { 31, "Hatay" },
                    { 32, "Isparta" },
                    { 33, "Mersin" },
                    { 34, "İstanbul" },
                    { 35, "İzmir" },
                    { 36, "Kars" },
                    { 37, "Kastamonu" },
                    { 38, "Kayseri" },
                    { 39, "Kırklareli" },
                    { 40, "Kırşehir" },
                    { 41, "Kocaeli" },
                    { 42, "Konya" },
                    { 43, "Kütahya" },
                    { 44, "Malatya" },
                    { 45, "Manisa" },
                    { 46, "Kahramanmaraş" },
                    { 47, "Mardin" },
                    { 48, "Muğla" },
                    { 49, "Muş" },
                    { 50, "Nevşehir" },
                    { 51, "Niğde" },
                    { 52, "Ordu" },
                    { 53, "Rize" },
                    { 54, "Sakarya" },
                    { 55, "Samsun" },
                    { 56, "Siirt" },
                    { 57, "Sinop" },
                    { 58, "Sivas" },
                    { 59, "Tekirdağ" },
                    { 60, "Tokat" },
                    { 61, "Trabzon" },
                    { 62, "Tunceli" },
                    { 63, "Şanlıurfa" },
                    { 64, "Uşak" },
                    { 65, "Van" },
                    { 66, "Yozgat" },
                    { 67, "Zonguldak" },
                    { 68, "Aksaray" },
                    { 69, "Bayburt" },
                    { 70, "Karaman" },
                    { 71, "Kırıkkale" },
                    { 72, "Batman" },
                    { 73, "Şırnak" },
                    { 74, "Bartın" },
                    { 75, "Ardahan" },
                    { 76, "Iğdır" },
                    { 77, "Yalova" },
                    { 78, "Karabük" },
                    { 79, "Kilis" },
                    { 80, "Osmaniye" },
                    { 81, "Düzce" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "INFORMATIONS",
                columns: new[] { "Id", "CityId", "Editor", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 1, 1, "Sabancı Merkez Camii, Varda(Alman) Köprüsü,Taş Köprü,Büyük Saat, Yılankale, Ulu Camii ve Külliyesi", "35-E-18", "37-N-01" },
                    { 2, 2, "Nemrut Dağı, Cendere Köprüsü,Pirin Ören Yeri Su Gözü,Gölbaşı Gölleri Tabiat Parkı ", "38-E-17", "37-N-46" },
                    { 3, 3, "Karahisar Kalesi,Ulu Camii,Frig Vadisi Tabiat Parkı,Başkomutan Tarihi Milli Parkı,Kocatepe  ", "30-E-33", "38-N-45" },
                    { 4, 4, "Ağrı Dağı,İshak Paşa Sarayı,Urartu Kalesi, Diyadin KAplıcaları,Kudret Köprüsü  ", "43-E-03", "39-N-44" },
                    { 5, 5, " II.Beyazıt Camii ve Külliyesi, Amasya Arkeoloji Müzesi, Amasya Kalesi,Boraboy Gölü Tabiat Parkı, Kral Kaya Mezarları ", "35-E-50", "40-N-40" },
                    { 6, 6, "Anıtkabir, Anadolu Medeniyetleri Müzesi,  I.TBMM Kurtuluş Savaşı Müzesi,Ankara Kalesi, II. TBMM Cumhuriyet Müzesi,Rahmi M. Koç Müzesi ", "32-E-52", "39-N-56" },
                    { 7, 7, "Kaleiçi,Apollon Tapınağı,Düden Şelalaesi, Kleopatra Plajı,Side Anfi Tiyatrosu ", "30-E-42 ", "36-N-54" },
                    { 8, 8, "Mençuna Şelalesi, Karagöl, Çifte Köprü, Borçka Tabiat Parkı, İşhan Kilisesi ", "41-E-49 ", "41-N-11" },
                    { 9, 9, " Dilek Yarımadası Milli Parkı, Aphrodisias Antik Kenti, Altınkum Plajı, Küçükada Kalesi, Priene Antik Kenti", "27-E-51 ", "37-N-51" },
                    { 10, 10, "Kaz Dağları, Şeytan Sofrası, Taksiyarhis Kilisesi, Kazdağları Milli Parkı, Şahinderesi Kanyonu ", "27-E-52", "39-N-39" },
                    { 11, 11, "Ertuğrul Gazi Türbesi, Şeyh Edebali Türbesi, Dursun Fakih Türbesi,Harmankaya Kanyonu Tabiat Parkı, Küçükelmalı Tabiat Parkı ", "29-E-59 ", "40-N-09" },
                    { 12, 12, "Yüzen Ada, 33 Şehit Anıtı, Buban Bacaları ", "40-E-29", "38-N-53" },
                    { 13, 13, " ", "42-E-06", "38-N-22" },
                    { 14, 14, "Gölcük Gölü, Abant Gölü, Yedigöller Milli Parkı, Göynük ZaferKulesi, Kartalkaya Kış Turizm Merkezi ", " 31-E-37", "40-N-44" },
                    { 15, 15, "Sagalassos Arkeolojik Buluntular, Salda Gölü,Arkeoloji Müzesi,Kibyra Antik Kenti,İnsuyu Mağarası ", "30-E-17", "37-N-43" },
                    { 16, 16, "Ulu Camii, Koza Hanı, Osman Gazi ve Orhan Gazi Türbeleri, Bursa Teleferik, Cumalıkızık", "29-E-04", "40-N-11" },
                    { 17, 17, " Truva Antik Kenti, Çanakkale Deniz Müzesi, Troya Müzesi,Conk Bayırı Mehmetçik Park Anıtı Kemalyeri Yazıtı, Kabatepe Kumsalı", "26-E-24 ", "40 N 09" },
                    { 18, 18, "Hazım Dağlı Tabiat Parkı, Tuz Mağarası, Çankırı Müzesi,Kırkpınar Yaylası, Bayramören Köprüsü  ", "33-E-37 ", "40-N-36" },
                    { 19, 19, " Hattuşaş, Yazılıkaya,Alacahöyük Müzesi,Aslanlı Kapı, İncesu Kanyonu ", "", "" },
                    { 20, 20, "Pamukkale Travertenleri,Gemiş Yamaç Paraşütü, Kaklık Mağarası,Kleopatra Havuzları  ", "", "" },
                    { 21, 21, "Ulu Camii, Diyarbakır Surları,Hasankeyf Eski Köprüsü,Surp Giragos Kilisesi,Hasan Paşa Hanı  ", "", "" },
                    { 22, 22, "Selimiye Camii, Bayezid Külliyesi ve Şifahane,KAraağaç, MEriç Köprüsü, Edirne büyük Sinagogu  ", "", "" },
                    { 23, 23, "Harput Kalesi, Keban Barajı, Şefik Gül Kültür Evi, Harput Ulu Camii,Kömürhan Köprüsü  ", "", "" },
                    { 24, 24, "Girlevik Şelalesi, KEmaliye Karanlık Kanyon, Ekşisu Mesire Alanı, Atatürk Portresi, Erzincan Saat Kulesi  ", "", "" },
                    { 25, 25, " Yakutiye Medresesi, Çifte Minareli Medrese, Tortum Şelalesi,Palandöken Dağı,Erzurum Kongre ve Milli Mücadele Müzesi ", "", "" },
                    { 26, 26, "Sazaova Parkı, Yılmaz Büyükerşen Balmumu Heykeller Müzesi, Eskişehir Bilim Sanat ve Kültür Parkı,Çağdaş Cam Sanatları MErkezi, Odunpazarı Evleri  ", "", "" },
                    { 27, 27, "Zeugma Mozaik Müzesi, Rumkale, Gaziantep Kalesi, Gaziantep Hayvanat Bahçesi, Gaziantep Oyun ve Oyuncak Müzesi  ", "", "" },
                    { 28, 28, "Giresun Kalesi, Kulakkaya Yaylası, Kuzalan Şelalesi,Kümbet Yaylası,Sis Dağı  ", "", "" },
                    { 29, 29, "Tomara Şelalesi Tabiat Parkı, Karaca Cave, Limni Gölü Tabiat Parkı,Taşköprü Yaylası,İkizevler Kent Müzesi  ", "", "" },
                    { 30, 30, " Beyaz Şelale, Cilo Buzulları, Sat Buzul Gölleri,Tarihi Taş Evler, Meydan MEdresesi ", "", "" },
                    { 31, 31, " Antakya Arkeoloji Müzesi,Eski Antakya,Habib-i Neccar Camii,Titus Kaya Tüneli, St. Pierre Kilisesi ", "", "" },
                    { 32, 32, "Eğirdir Gölü, Kuyucak Köyü, Süleyman Demirel Demokrasi ve Kalkınma Müzesi,Zindan Mağarası, Kızıldağ Milli Parkı  ", "", "" },
                    { 33, 33, "Aynalıgöl Mağarası, Uzuncaburç Olba Antik Kenti, Mut Yerköprü Şelalesi,Kızkalesi, Alahan Manastırı   ", "", "" },
                    { 34, 34, "Ayasofya Camii, Galata Kulesi, Gülhane Parkı, Dolmabahçe Sarayı, Yerebatan Sarnıcı    ", "", "" },
                    { 35, 35, " Kordon Boyu, Kemeraltı Çarşısı,Saat Kulesi,Tarihi Asansör,İzmir Doğal Yaşam Parkı  ", "", "" },
                    { 36, 36, " Ani Antik Kenti,Havariler Müzesi, Kars Kalesi,Ani Katedrali, Kafkas Cephesi Harp Tarihi Müzesi  ", "", "" },
                    { 37, 37, "Hz. Pir Şeyh Şaban-i Veli Külliyesi, Ilıca Şelalesi, Nasrullah Camii,Kastamonu Kalesi,Valla Kanyonu Seyir Terası   ", "", "" },
                    { 38, 38, " Erciyes Dağı, Hunat Hatun Külliyesi,Soğanlı Vadisi,Kayseri Lisesi Milli Mücadele Müzesi, Mimar Sinan Evi ", "", "" },
                    { 39, 39, "İğneada Longoz Ormanları Milli Parkı, Dupnisa Mağarası,Atatürk Evi,Kıyıköy Çiftliği, Sokullu Mehmet Paşa Camii   ", "", "" },
                    { 40, 40, "Japon Bahçesi, Cacabey MEdresesi, Kaman KAlehöyük Arkeoloji Müzesi,Ahi Evran Külliyesi ve Camii,Neşet Etraş Kültür Merkezi   ", "", "" },
                    { 41, 41, "Ormanya,Gayret Gemi Müzesi,İzmit Saat Kulesi,Kocaeli Bilim Müzesi, Pembe KayalarBallıkayalar Kanyonu   ", "", "" },
                    { 42, 42, "Mevlana Müzesi, Konya Tropikal Kelebek Bahçesi, Sille Köyü, Aziziye Camii, Konya Bilim Merkezi  ", "", "" },
                    { 43, 43, " Aizanoi Antik Kenti, Dumlupınar Şehitliği,Kütahya Kalesi, Macar Evi Müzesi,Çini Müzesi  ", "", "" },
                    { 44, 44, "  Şire Pazarı,Silahtar Mustafa Paşa Kervansarayı, Levent Vadisi, Malatya Beşkonaklar Etnografya Müzesi, Aslantepe Ören Yeri ", "", "" },
                    { 45, 45, "Spil Dağı, Aigai Antik Kenti, Manisa Müzesi,Süreyya Tabiat Parkı, Kula Peribacaları", "", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_INFORMATIONS_CityId",
                schema: "dbo",
                table: "INFORMATIONS",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_VISITORHISTORIES_CityId",
                schema: "dbo",
                table: "VISITORHISTORIES",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INFORMATIONS",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "VISITORHISTORIES",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CITIES",
                schema: "dbo");
        }
    }
}
