internal class Program
{
    private static void Main(string[] args)
    {
        //Generic yöntemini kullanarak.... 

        Example<string> Example_1=new Example<string>();
        Example_1.example_1 = "Ertugrul Daglı";
        Example_1.example_2("c#");


        Example<int> Example_2 = new Example<int>();
        Example_2.example_1 = 20;
        Example_2.example_2(200);


        Example<double> Example_3 = new Example<double>();
        Example_3.example_1 = 132.55;
        Example_3.example_2(56.23);





    }


    public class Example
    {

        public int expamle_1;

        public void examaple_2(int parameter)
        {
            Console.WriteLine("Parametre değeri: " + parameter);
        }
    
    }

    //generic harici yapı kullandığında değişkenler, parametreler ve metotların gei dönüş tipleri gibi durumları o sınıftan bir nesne oluştururken belirlenebilmesi

    public class Example<T>
    {
        public T example_1;

        public void example_2(T parameter)
        {

        }
    }

}