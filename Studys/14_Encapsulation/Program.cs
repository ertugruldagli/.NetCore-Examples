using _14_Encapsulation;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Normal Durum

        clsBank bank = new clsBank();

        bank.AcountNumber = 123465798;
        bank.Name = "Santander Bank";
        bank.Balance = 500;

        bank.GetBalance();
        bank.WithdrawAccount();
        bank.depoasit();

        #endregion



        #region Getter setter

        //clsBank bankGS=new clsBank();
        //bankGS.SetBalanceCaps(500);

        //Console.WriteLine($"Balance miktarı: {bankGS.GetBalanceCaps()}");


        #endregion



        #region Eğer sınıfı tasarlarken Kapsülleme prensibine uyulmazsa ne olur?

        //clsBank bank2 = new clsBank();

        ////pozitif bir değerle amount değerini güncelleyin

        //bank2.Amount = 100;

        //Console.WriteLine($"Benkadaki miktar: {bank2.Amount} PNG Kina");

        //bank2.Amount = -150;

        //Console.WriteLine($"Benkadaki miktar: {bank2.Amount} PNG Kina");




        //hata yakalama bölümü
        //try
        //{
        //    int deger;

        //    clsBank bank3= new clsBank();

        //    Console.WriteLine("Lütfen bir sayi griiniz: ");
        //    deger=Convert.ToInt32( Console.ReadLine() );
        //    bank3.SetAmount(deger);
        //    Console.WriteLine($"\n\n Düzgün durum \n\nBenkadaki miktar: {bank3.GetAmount()} PNG Kina");


        //    Console.WriteLine("Lütfen bir sayi griiniz: ");
        //    deger = Convert.ToInt32(Console.ReadLine());
        //    bank3.SetAmount(deger);
        //    Console.WriteLine($"Bankadaki miktar: {bank3.GetAmount()} PNG Kina");
        //}
        //catch (Exception hata)
        //{
        //    Console.WriteLine(hata.Message);
        //}




        #endregion



        #region Properteis / Değişkenlere de uygulanabilir







        #endregion


        Console.ReadKey();
    }
}