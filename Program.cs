


int dogruSayisi = 0;


Console.WriteLine("SORU 1 : KIZINCA TÜKÜREN HEYVEN ? (A/B) \nA) LAMA B) DEVE");
string c1 = Console.ReadLine().ToLower();

if (c1 == "a")
{
    Console.WriteLine("DOĞRU CEVAP \n");
    dogruSayisi++;
}
else
{
    Console.WriteLine("YANLIŞ CEVAP\n");
}



Console.WriteLine("SORU 2 : DÜNYAYA EN YAKIN GEZEGEN ? (A/B) \nA) VENÜS B) MARS");
string c2 = Console.ReadLine().ToLower();

if (c2 == "a")
{
    Console.WriteLine("DOĞRU CEVAP \n");
    dogruSayisi++;
}
else 
{
    Console.WriteLine("YANLIŞ CEVAP\n");
}

if (dogruSayisi >= 2)
{
    Console.WriteLine("TEBRİKLER KAZANDINIZ ");
}

else
{
    Console.WriteLine("SORU 3 : 5 * 2 + 8 / 2 - 2 ? (A/B) \nA) 7 B) 12");
    string c3 = Console.ReadLine().ToLower();

    if (c3 == "b")
    {
        Console.WriteLine("DOĞRU CEVAP\n");
        dogruSayisi++;
    }
    else
    {
        Console.WriteLine("YANLIŞ CEVAP\n");
        Console.WriteLine("KAYBETTİNİZ");
    }
    

}


