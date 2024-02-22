namespace szotar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Egy 20 elemű tömb előállítása véletlen számokkal 0..9 intervallumban
            int[] szamok = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                szamok[i] = rnd.Next(10);
            }
            //Szótár létrehozása
            Dictionary<int, int> szamokSzama = new Dictionary<int, int>(); //vagy a jobb oldal: new();
            //Megszámoljuk, hogy hányszor fordul elő egy adott szám a tömbben
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamokSzama.ContainsKey(szamok[i]))
                {
                    szamokSzama[szamok[i]]++;
                }
                else
                {
                    szamokSzama.Add(szamok[i], 1);
                }
            }
            //Kiíratjuk melyik számból hány volt a tömbben
            foreach (var elem in szamokSzama)
                //pontosabban: (KeyValuePair<int, int> elem in szamokSzama)
            {
                Console.WriteLine($"{elem.Key}: {elem.Value} db");
            }

        }
    }
}
