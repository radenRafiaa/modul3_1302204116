﻿using System;

public class KodeBuah
{
    public enum NamaBuah {
        Apel, 
        Aprikot, 
        Alpukat, 
        Pisang, 
        Paprika, 
        Blackberry, 
        Ceri, 
        Kelapa, 
        Jagung, 
        Kurma, 
        Durian, 
        Anggur, 
        Melon, 
        Semangka
    }
    public string GetKodebuah(NamaBuah namabuah)
    {
        string[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

        return kodebuah[(int)namabuah];
    }
}

