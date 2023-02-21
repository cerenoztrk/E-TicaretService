using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class Musteri
{
    public int MusteriId { get; set; }

    public string MusteriAdi { get; set; } = null!;

    public string MusteriSoyadi { get; set; } = null!;

    public int CinsiyetId { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Adres { get; set; }

    public int SehirId { get; set; }

    public virtual Cinsiyet Cinsiyet { get; set; } = null!;

    public virtual Sehir MusteriNavigation { get; set; } = null!;

    public virtual ICollection<Odeme> Odemes { get; } = new List<Odeme>();

    public virtual ICollection<Sipari> Siparis { get; } = new List<Sipari>();

    public virtual ICollection<Tahsilat> Tahsilats { get; } = new List<Tahsilat>();
}
