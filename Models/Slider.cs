namespace e_commerce.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Resim { get; set; } = null!;
        public string? Baslik { get; set; }
        public string Aciklama { get; set; } = null!;
   
        public bool Aktif { get; set; }
        public int Index { get; set; }
     
    }
}