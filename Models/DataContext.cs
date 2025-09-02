using Microsoft.EntityFrameworkCore;

namespace e_commerce.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
            
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
       
       override protected void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Kategori>().HasData(
               new List<Kategori>
               {
                   new Kategori { Id = 1, KategoriAdi = "Telefon", Url="telefon" },
                   new Kategori { Id = 2, KategoriAdi = "Elektronik", Url="elektronik" },
                   new Kategori { Id = 3, KategoriAdi = "Beyaz Eşya", Url="beyaz-esya" },
                   new Kategori { Id = 4, KategoriAdi = "Giyim", Url="giyim" },
                   new Kategori { Id = 5, KategoriAdi = "Kozmetik", Url="kozmetik" },
                    new Kategori { Id = 6, KategoriAdi = "Kategori 1", Url="kategori-1" },
                     new Kategori { Id = 7, KategoriAdi = "Kategori 2", Url="kategori-2" },
                      new Kategori { Id = 8, KategoriAdi = "Kategori 3", Url="kategori-3" },
                       new Kategori { Id = 9, KategoriAdi = "Kategori 4", Url="kategori-4" }

               }
                 );


            modelBuilder.Entity<Urun>().HasData(
              new List<Urun>
              {
                   new Urun { Id = 1, UrunAdi = "Apple Watch 8", Fiyat = 15000, Aktif = true , Anasayfa=true, Aciklama="Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", Resim="1.jpeg" ,KategoriId=1 },
                   new Urun { Id = 2, UrunAdi = "Apple Watch 9", Fiyat = 8000, Aktif = false ,Anasayfa=true, Aciklama="Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", Resim="2.jpeg",KategoriId=2 },
                   new Urun { Id = 3, UrunAdi = "Apple Watch 10", Fiyat = 6000, Aktif = true,Anasayfa=false, Aciklama="Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", Resim="3.jpeg" ,KategoriId=3 },
                   new Urun { Id = 4, UrunAdi = "Apple Watch 11", Fiyat = 1200, Aktif = false,Anasayfa=false, Aciklama="Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", Resim="4.jpeg",KategoriId=4 },
                   new Urun { Id = 5, UrunAdi = "Apple Watch 12", Fiyat = 3500, Aktif = true,Anasayfa=false, Aciklama="Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", Resim="5.jpeg" ,KategoriId=4 },
                     new Urun { Id = 6, UrunAdi = "Apple Watch 12", Fiyat = 3500, Aktif = true,Anasayfa=true, Aciklama="Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", Resim="6.jpeg",KategoriId=2  },
                   new Urun { Id = 7, UrunAdi = "Apple Watch 13", Fiyat = 90000, Aktif = false,Anasayfa=true, Aciklama="Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", Resim="7.jpeg",KategoriId=1  },
                  new Urun { Id = 8, UrunAdi = "Apple Watch 14", Fiyat = 80500, Aktif = true,Anasayfa=false, Aciklama="Apple Watch 8 41mm Alüminyum Kasa ve Spor Kordon", Resim="8.jpeg",KategoriId=5  }

            }
                );
        }
    }
}