class Program
{
    static Board board = new Board();
    static Takim takim = new Takim();

    static void Main(string[] args)
    {
        // Varsayılan kartları ekleyelim
        board.KartEkle(new Kart("Kart1", "İçerik1", takim.UyeListesi[1], Buyukluk.M), 1);
        board.KartEkle(new Kart("Kart2", "İçerik2", takim.UyeListesi[2], Buyukluk.L), 2);
        board.KartEkle(new Kart("Kart3", "İçerik3", takim.UyeListesi[3], Buyukluk.S), 3);

        // Menü
        while (true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(0) Uygulamayı Sonlandırmak");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    BoardListele();
                    break;
                case 2:
                    KartEkle();
                    break;
                case 3:
                    KartSil();
                    break;
                case 4:
                    KartTasi();
                    break;
                case 0:
                    Console.WriteLine("Uygulama sonlandırılıyor...");
                    Environment.Exit(0);  // Uygulamayı sonlandır
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    static void BoardListele()
    {
        board.BoardListele();
    }

    static void KartEkle()
    {
        Console.WriteLine("Başlık Giriniz: ");
        string baslik = Console.ReadLine();

        Console.WriteLine("İçerik Giriniz: ");
        string icerik = Console.ReadLine();

        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
        Buyukluk buyukluk = (Buyukluk)int.Parse(Console.ReadLine());

        Console.WriteLine("Kişi Seçiniz: ");
        foreach (var uye in takim.UyeListesi)
        {
            Console.WriteLine($"{uye.Key} - {uye.Value}");
        }

        int uyeId = int.Parse(Console.ReadLine());

        if (!takim.UyeListesi.ContainsKey(uyeId))
        {
            Console.WriteLine("Hatalı giriş yaptınız!");
            return;
        }

        string atananKisi = takim.UyeListesi[uyeId];

        Console.WriteLine("Kart hangi line'a eklensin? (1) TODO (2) IN PROGRESS (3) DONE: ");
        int line = int.Parse(Console.ReadLine());

        board.KartEkle(new Kart(baslik, icerik, atananKisi, buyukluk), line);
    }

    static void KartSil()
    {
        Console.WriteLine("Lütfen silmek istediğiniz kartın başlığını yazınız: ");
        string baslik = Console.ReadLine();

        // TODO: Kart silme işlemi
    }

    static void KartTasi()
    {
        Console.WriteLine("Lütfen taşımak istediğiniz kartın başlığını yazınız: ");
        string baslik = Console.ReadLine();

        // TODO: Kart taşıma işlemi
    }
}
