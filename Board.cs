public class Board
{
    public List<Kart> TodoList = new List<Kart>();
    public List<Kart> InProgressList = new List<Kart>();
    public List<Kart> DoneList = new List<Kart>();

    public void KartEkle(Kart kart, int line)
    {
        switch(line)
        {
            case 1:
                TodoList.Add(kart);
                break;
            case 2:
                InProgressList.Add(kart);
                break;
            case 3:
                DoneList.Add(kart);
                break;
        }
    }

    public void BoardListele()
    {
        Console.WriteLine("TODO Line");
        Console.WriteLine("************************");
        ListeyiYazdir(TodoList);
        
        Console.WriteLine("IN PROGRESS Line");
        Console.WriteLine("************************");
        ListeyiYazdir(InProgressList);
        
        Console.WriteLine("DONE Line");
        Console.WriteLine("************************");
        ListeyiYazdir(DoneList);
    }

    private void ListeyiYazdir(List<Kart> kartList)
    {
        if (kartList.Count == 0)
        {
            Console.WriteLine("~ BOŞ ~");
        }
        else
        {
            foreach (var kart in kartList)
            {
                Console.WriteLine($"Başlık      : {kart.Baslik}");
                Console.WriteLine($"İçerik      : {kart.Icerik}");
                Console.WriteLine($"Atanan Kişi : {kart.AtananKisi}");
                Console.WriteLine($"Büyüklük    : {kart.KartBuyukluk}");
                Console.WriteLine("-");
            }
        }
    }
}
