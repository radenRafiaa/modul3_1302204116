using modul3_1302204116;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeBuah ph = new KodeBuah();

            KodeBuah.NamaBuah nb1 = KodeBuah.NamaBuah.Apel;
            KodeBuah.NamaBuah nb2 = KodeBuah.NamaBuah.Aprikot;
            KodeBuah.NamaBuah nb3 = KodeBuah.NamaBuah.Alpukat;
            KodeBuah.NamaBuah nb4 = KodeBuah.NamaBuah.Pisang;
            KodeBuah.NamaBuah nb5 = KodeBuah.NamaBuah.Paprika;
            KodeBuah.NamaBuah nb6 = KodeBuah.NamaBuah.Blackberry;
            KodeBuah.NamaBuah nb7 = KodeBuah.NamaBuah.Ceri;
            KodeBuah.NamaBuah nb8 = KodeBuah.NamaBuah.Kelapa;
            KodeBuah.NamaBuah nb9 = KodeBuah.NamaBuah.Jagung;
            KodeBuah.NamaBuah nb10 = KodeBuah.NamaBuah.Kurma;
            KodeBuah.NamaBuah nb11 = KodeBuah.NamaBuah.Durian;
            KodeBuah.NamaBuah nb12 = KodeBuah.NamaBuah.Anggur;
            KodeBuah.NamaBuah nb13 = KodeBuah.NamaBuah.Melon;
            KodeBuah.NamaBuah nb14 = KodeBuah.NamaBuah.Semangka;
            Console.WriteLine("Nama Buah" + "    " + "Kode Buah");
            Console.WriteLine(nb1 + "         " + ph.GetKodebuah(nb1));
            Console.WriteLine(nb2 + "      " + ph.GetKodebuah(nb2));
            Console.WriteLine(nb3 + "      " + ph.GetKodebuah(nb3));
            Console.WriteLine(nb4 + "       " + ph.GetKodebuah(nb4));
            Console.WriteLine(nb5 + "      " + ph.GetKodebuah(nb5));
            Console.WriteLine(nb6 + "   " + ph.GetKodebuah(nb6));
            Console.WriteLine(nb7 + "         " + ph.GetKodebuah(nb7));
            Console.WriteLine(nb8 + "       " + ph.GetKodebuah(nb8));
            Console.WriteLine(nb9 + "       " + ph.GetKodebuah(nb9));
            Console.WriteLine(nb10 + "        " + ph.GetKodebuah(nb10));
            Console.WriteLine(nb11+ "       " + ph.GetKodebuah(nb11));
            Console.WriteLine(nb12 + "       " + ph.GetKodebuah(nb12));
            Console.WriteLine(nb13 + "        " + ph.GetKodebuah(nb13));
            Console.WriteLine(nb14 + "     " + ph.GetKodebuah(nb14));
            Console.WriteLine("\n ");

            PosisiKarakterGame posisiKarakter = new PosisiKarakterGame();
            Console.WriteLine(posisiKarakter.currentState);

            posisiKarakter.activeTrigger(PosisiKarakterGame.Trigger.TombolX);
            Console.Write("Posisi Sedang : ");
            Console.Write(posisiKarakter.currentState);

            Console.WriteLine("\n ");

            Console.Write(posisiKarakter.currentState);
            posisiKarakter.activeTrigger(PosisiKarakterGame.Trigger.TombolW);
            Console.Write("Posisi Sedang : ");
            Console.Write(posisiKarakter.currentState);

            Console.WriteLine("\n ");

            Console.Write(posisiKarakter.currentState);
            posisiKarakter.activeTrigger(PosisiKarakterGame.Trigger.TombolW);
            Console.Write("Posisi Sedang : ");
            Console.Write(posisiKarakter.currentState);
        }
    }
}