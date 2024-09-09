public class Kart
{
    public string Baslik { get; set; }
    public string Icerik { get; set; }
    public string AtananKisi { get; set; }
    public Buyukluk KartBuyukluk { get; set; }

    public Kart(string baslik, string icerik, string atananKisi, Buyukluk buyukluk)
    {
        Baslik = baslik;
        Icerik = icerik;
        AtananKisi = atananKisi;
        KartBuyukluk = buyukluk;
    }
}
