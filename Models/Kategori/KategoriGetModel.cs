namespace e_commerce.Models
{

    public class KategoriGetModel
    {
         public int Id { get; set; }
        public string KategoriAdi { get; set; } = null!;
        public string Url { get; set; } = null!;

        public int UrunSayisi { get; set; }
    }
}