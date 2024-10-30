namespace MVCCRUD.Entities.Concrete
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public ICollection<Siparis> Siparisler { get; set; }
    }
}
