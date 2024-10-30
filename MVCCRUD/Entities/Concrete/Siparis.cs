﻿namespace MVCCRUD.Entities.Concrete
{
    public class Siparis
    {
        public int Id { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }
    }
}
