internal class Program
{
    private static void Main(string[] args)
    {
        Database database = new Oracle();
        database.remove();
        database.add();
    }

    abstract class Database
    {
        public void add()
        {
            Console.WriteLine("added");
        }
        public abstract void remove();
    }
    class SqlServer:Database { 
        public override void remove()
        {
            Console.WriteLine("silindi");
        }
    
    }
    class Oracle : Database
    {
        public override void remove()
        {
            Console.WriteLine("oracledan silindi");
        }
    }

}