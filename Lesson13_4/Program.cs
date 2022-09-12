namespace Lesson13_4;


class Program
{
    static void Main()
    {
        // Boxing vs Unboxing


        // Reference type <= Value type  (Boxing)
        // Reference type => Value type  (Unboxing)

        int x = 10;
        object obj = x;     // (Boxing)

        int y = (int)obj;   // (Unboxing)



        object o = "Hello";


        // List<object> list = new List<object>();
    }
}