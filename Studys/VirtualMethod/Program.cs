internal class Program
{
    private static void Main(string[] args)
    {
        SqlServer s=new SqlServer();
        s.add();

        MySql m=new MySql();
        m.add();


        Console.ReadLine();
    }

    class Database
    {
        public virtual void add()
        {
            Console.WriteLine("add");
        }
        public virtual void remove() {
            Console.WriteLine("remove");
                }


    }
    class SqlServer: Database { 
        public override void add()
        {
            Console.WriteLine("sqlden");
        }
    }
    class MySql: Database {
    
    
    }

}