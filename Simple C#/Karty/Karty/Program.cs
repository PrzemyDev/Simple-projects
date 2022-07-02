namespace Karty
{
    class Program
    {
        static void Main()
        {
            //Tworzenie kart:
            List<Karta> karty = new List<Karta>();
            InicjalizacjaKart ik = new InicjalizacjaKart(ref karty);

            foreach (var karta in karty)
            {
                karta.OdslonKarte();

            }//Debug
            Console.WriteLine("\nilość kart:" + karty.Count + "\n");

            //Tasowanie talii
            TasowanieKart tk = new TasowanieKart(ref karty);

            foreach (var karta in karty)
            {
                karta.OdslonKarte();
            }//Debug
        }
    }

    internal class TasowanieKart
    {
        public TasowanieKart(ref List<Karta> refList)
        {
            Console.Write("----------Tasowanie kart :------------------\n");
            Random random = new Random();
            refList = refList.OrderBy(_ => random.Next()).ToList();
        }
    }

    internal class InicjalizacjaKart
    {

        public InicjalizacjaKart(ref List<Karta> refList)
        {
            Console.Write("----------Tworzenie talii kart------------------\n");

            for (int i = 2; i <= 14; i++)
            {
                refList.Add(new Karta(i, "Pik♠", null));
                refList.Add(new Karta(i, "Kier♥", null));
                refList.Add(new Karta(i, "Trefl♣", null));
                refList.Add(new Karta(i, "Karo♦", null));
            }
        }
    }

    internal class Karta
    {
        private int _wartosc;
        private string _kolor;
        private string? _tempWartosc;

        internal Karta(int wartosc, string kolor, string? tempWartosc)
        {
            _wartosc = wartosc;
            _kolor = kolor;

            if (tempWartosc != null)
                _tempWartosc = tempWartosc;
            else
            {
                _tempWartosc = wartosc.ToString();
            }
        }

        internal void OdslonKarte()
        {
            if (_wartosc > 10)
            {
                switch (_wartosc)
                {
                    case 11:
                        _tempWartosc = "Walet";
                        break;
                    case 12:
                        _tempWartosc = "Dama";
                        break;
                    case 13:
                        _tempWartosc = "Król";
                        break;
                    case 14:
                        _tempWartosc = "AS";
                        break;
                }
                Console.WriteLine($"Karta {_tempWartosc} {_kolor} ");
            }
            else
                Console.WriteLine($"Karta {_wartosc} {_kolor} ");
        }
    }
}



