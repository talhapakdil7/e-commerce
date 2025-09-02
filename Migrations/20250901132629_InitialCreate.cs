using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_commerce.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KategoriAdi = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrunAdi = table.Column<string>(type: "TEXT", nullable: true),
                    Resim = table.Column<string>(type: "TEXT", nullable: true),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: true),
                    Fiyat = table.Column<double>(type: "REAL", nullable: false),
                    Anasayfa = table.Column<bool>(type: "INTEGER", nullable: false),
                    Aktif = table.Column<bool>(type: "INTEGER", nullable: false),
                    KategoriId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "KategoriAdi", "Url" },
                values: new object[,]
                {
                    { 1, "Telefon", "telefon" },
                    { 2, "Elektronik", "elektronik" },
                    { 3, "Beyaz Eşya", "beyaz-esya" },
                    { 4, "Giyim", "giyim" },
                    { 5, "Kozmetik", "kozmetik" }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "Aciklama", "Aktif", "Anasayfa", "Fiyat", "KategoriId", "Resim", "UrunAdi" },
                values: new object[,]
                {
                    { 1, "Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", true, true, 15000.0, 1, "1.jpeg", "Apple Watch 8" },
                    { 2, "Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", false, true, 8000.0, 2, "2.jpeg", "Apple Watch 9" },
                    { 3, "Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", true, false, 6000.0, 3, "3.jpeg", "Apple Watch 10" },
                    { 4, "Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", false, false, 1200.0, 4, "4.jpeg", "Apple Watch 11" },
                    { 5, "Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", true, false, 3500.0, 4, "5.jpeg", "Apple Watch 12" },
                    { 6, "Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", true, true, 3500.0, 2, "6.jpeg", "Apple Watch 12" },
                    { 7, "Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", false, true, 90000.0, 1, "7.jpeg", "Apple Watch 13" },
                    { 8, "Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", true, false, 80500.0, 5, "8.jpeg", "Apple Watch 14" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
