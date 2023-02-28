internal class Program
{
    static int pdayCount;

    private static int retirementCalc(string prmGender,int day)
    {

        int dayforman = 9000;
        int dayforwoman = 7200;

        switch (prmGender)
        {
            case "E":
                day = dayforman - pdayCount;
                break;
            case "K":
                day=dayforwoman-pdayCount;
                break;
            default:
                break;
        }
        return day;
    }

    private static void Main(string[] args)
    {
        //Erkeklerin 25 yıl
        // kadınalrın 20 yıl da emekli olacağını bir ortamda
        //klavyeden cinsiyet ve sigorta prim gün sayısı girilecek
        //emekliliğe ne kadar kaldı?

        // 1 yıl=360
        //1 ay =30

        int YEAR = 360;
        int AY = 30;
     

        string gender;

        Console.WriteLine("Lütfen cinsiyet bilgisini giriniz: E/K");
        gender = Console.ReadLine().ToUpper();

        Console.WriteLine("lütfen prim gün sayısını giriniz: ");
        pdayCount=Convert.ToInt32(Console.ReadLine()); //prim gün sayısı


        int year =retirementCalc(gender,pdayCount) /YEAR;
        pdayCount %= YEAR;

        int month = retirementCalc(gender, pdayCount) / AY;
        pdayCount%= AY;

        int day = pdayCount;

        Console.WriteLine($"\n\nEmekliliğinize {YEAR} yıl {AY} ay {day} gun kalmistir.");

        Console.ReadLine();
    }
}