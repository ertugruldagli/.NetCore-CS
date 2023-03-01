using System.Security.Claims;

internal class Program
{
    private static void Main(string[] args)
    {


        #region part00
        string name;
        string nameDesc;
        string Name;
        string NameDesc;

        name = "Ertugrul Dagli "; // değişkene değer atama
        nameDesc = "Benim adım : ";
        NameDesc = "Hocamın adı : ";
        Name = "Umit Karaçivi";

        Console.WriteLine(nameDesc + name + "\n\n\n\t");
        Console.WriteLine(NameDesc + Name);
        #endregion

        #region part01
        byte a = 5;
        byte a1 = 255;

        int sum=a+a1;

        Console.WriteLine("Toplam degeri = " + sum.ToString() + "\n\n");




        #endregion

        #region part02
        byte s1 = 5, s2 = 15;
        int topla=s1+s2;
        string str1 = "merhaba ", str2 = "adim ertu";

        Console.WriteLine("Sayilarin toplami: " + topla.ToString());
        Console.WriteLine(str1 + str2);
        #endregion

        #region part03
        //erkana isim basma
        
        Console.Write("Bir isim giriniz: ");
        string isim=Convert.ToString(Console.ReadLine()); //isim=Console.ReadLine(); aynı görevi görür.
        Console.WriteLine("Hos geldiniz " + isim + " bey");

        #endregion

        #region part04
        //sık yapilan hatalar
        // aynı satırda farklı veri tiplerinden tanımlama yapma.
        //tanımlanan değişkene tanımlandığı tipten farklı değer atama.
        //değişkenı tanımlamadan üzerine değer atama.
        //değişkenin tanımlama yerinin yanlış yerde yapılması
        //bazı değişken türlerinde (float) gerekli bazı tanımlamaların yapılmaması
        // float veri tiplerinde virgül yerine nokta işareti kullanılır.

        //string abc = "654654";
        //string ab = "46545656";
        //int cvb=Convert.ToInt32(abc)+ Convert.ToInt32(ab);
            




        #endregion

        Console.ReadKey();



    }
}