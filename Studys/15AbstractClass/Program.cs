using _15AbstractClass;

internal class Program
{
    private static void Main(string[] args)
    {

    //öncelikle bir beden işçisi oluşturalım 

        clsCreateEmployeeManage  bodyWorker = new clsCreateEmployeeManage();

        bodyWorker.employeeBaseManager = new clsEmployeeManager();

        bodyWorker.Create();

        bodyWorker.getInfo();

        //bir mühendis için 

        clsCreateEmployeeManage engineer=new clsCreateEmployeeManage();

        engineer.employeeBaseManager = new clsEngineerManager();   // mühendisler için

        engineer.Create();
        engineer.getInfo();







        Console.ReadKey();
    }
}