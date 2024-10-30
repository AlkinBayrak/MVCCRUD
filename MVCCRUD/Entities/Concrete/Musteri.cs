namespace MVCCRUD.Entities.Concrete
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public ICollection<Siparis> Siparisler { get; set; }
    }
}
