namespace e_commerce.Models;

public class Urun
{
    public int Id { get; set; }
    public string? UrunAdi { get; set; }
    public string? Resim { get; set; }
    public string? Aciklama { get; set; }
    public double Fiyat { get; set; }
    public bool Anasayfa { get; set; }
    public bool Aktif { get; set; }

    public int KategoriId { get; set; }
    
    public Kategori kategori { get; set; }= null!;
}
    
