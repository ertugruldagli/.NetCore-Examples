using _14_Encapsulation;

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


        clsBank bankGS=new clsBank();
        bankGS.SetBalanceCaps(500);

        Console.WriteLine($"Balance miktarı: {bankGS.GetBalanceCaps()}");


        #endregion

        Console.ReadKey();
    }
}