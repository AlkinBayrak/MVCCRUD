using Microsoft.EntityFrameworkCore;
using MVCCRUD.Entities.Concrete;

namespace MVCCRUD.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musteri>().HasData(new[]
            {
      new Musteri { Id = 1, Ad = "Ali", Soyad = "Yılmaz", Email = "ali.yilmaz@example.com" },
      new Musteri { Id = 2, Ad = "Ayşe", Soyad = "Kara", Email = "ayse.kara@example.com" },
      new Musteri { Id = 3, Ad = "Mehmet", Soyad = "Demir", Email = "mehmet.demir@example.com" },
      new Musteri { Id = 4, Ad = "Fatma", Soyad = "Öztürk", Email = "fatma.ozturk@example.com" },
      new Musteri { Id = 5, Ad = "Hasan", Soyad = "Çelik", Email = "hasan.celik@example.com" },
      new Musteri { Id = 6, Ad = "Zeynep", Soyad = "Koç", Email = "zeynep.koc@example.com" },
      new Musteri { Id = 7, Ad = "Emre", Soyad = "Aydın", Email = "emre.aydin@example.com" },
      new Musteri { Id = 8, Ad = "Seda", Soyad = "Akman", Email = "seda.akman@example.com" },
      new Musteri { Id = 9, Ad = "Burak", Soyad = "Sönmez", Email = "burak.sonmez@example.com" },
      new Musteri { Id = 10, Ad = "Elif", Soyad = "Yavuz", Email = "elif.yavuz@example.com" }
  });

            modelBuilder.Entity<Urun>().HasData(new[]
            {
      new Urun { Id = 1, UrunAdi = "Laptop", Fiyat = 2500 },
      new Urun { Id = 2, UrunAdi = "Akıllı Telefon", Fiyat = 1500 },
      new Urun { Id = 3, UrunAdi = "Tablet", Fiyat = 1200 },
      new Urun { Id = 4, UrunAdi = "Kulaklık", Fiyat = 300 },
      new Urun { Id = 5, UrunAdi = "Masaüstü Bilgisayar", Fiyat = 2000 },
      new Urun { Id = 6, UrunAdi = "Monitör", Fiyat = 800 },
      new Urun { Id = 7, UrunAdi = "Klavyeli", Fiyat = 400 },
      new Urun { Id = 8, UrunAdi = "Yazıcı", Fiyat = 600 },
      new Urun { Id = 9, UrunAdi = "Modem", Fiyat = 250 },
      new Urun { Id = 10, UrunAdi = "Harici Disk", Fiyat = 500 }
  });

            modelBuilder.Entity<Siparis>().HasData(new[]
            {
      new Siparis { Id = 1, MusteriId= 1, UrunId = 1, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 2, MusteriId= 1, UrunId = 2, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 3, MusteriId= 2, UrunId = 3, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 4, MusteriId= 2, UrunId = 4, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 5, MusteriId= 3, UrunId = 5, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 6, MusteriId= 3, UrunId = 6, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 7, MusteriId= 4, UrunId = 7, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 8, MusteriId= 5, UrunId = 8, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 9, MusteriId= 6, UrunId = 9, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 10,MusteriId = 7,UrunId= 10, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 11,MusteriId = 8,UrunId= 1, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 12,MusteriId = 9,UrunId= 2, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 13,MusteriId = 10,UrunId = 3, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 14,MusteriId = 4,UrunId= 5, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 15,MusteriId = 5,UrunId= 6, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 16,MusteriId = 6,UrunId= 7, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 17,MusteriId = 7,UrunId= 8, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 18,MusteriId = 8,UrunId= 9, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 19,MusteriId = 9,UrunId= 10, SiparisTarihi = DateTime.Now },
      new Siparis { Id = 20,MusteriId = 10,UrunId = 1, SiparisTarihi = DateTime.Now }
  });
        }
    }
}
