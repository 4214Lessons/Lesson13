namespace Lesson13_3;

#nullable disable

// interface IRequest<in T>{}
// interface IRequest<out T>{}
interface IRequest<T>{}
interface IRequest<T1, TResult>{}
interface IRequest { }

struct SomeStruct<T> { }
record Somerecord<T> { }
delegate void SomeDel<T>();




class SomeClass<T> 
{
    public T Data { get; set; }
    private readonly T _privateField;

    public T Foo<TMethod>()
    {
        // T temp = default(T);
        T temp = default;
        TMethod param = default;

        Console.WriteLine("Foo<TMethod>");
        Console.WriteLine(temp);
        Console.WriteLine(param);

        return temp;
    }


    public T Foo()
    {
        // T temp = default(T);
        T temp = default;

        Console.WriteLine("Foo");
        Console.WriteLine(temp);

        return temp;
    }


    public void Serialize<T>(T param) { }
}



//// Constraints
// 1) struct (value type)
// 2) class  (reference type)
// 3) new()
// 4) Base class name
// 5) Base interface name
// 6) T:U

// 7) unmanaged
// 8) notnull
// 9) default







// abstract class Test 
// {
//     public Test(){}
// }
// 
// 
// 
// class Base<T> where T : class, new()
// {
//     public void Foo()
//     {
//         T temp = new T();
//     }
// }










abstract class Base { }
class Derived1 : Base { }
class Derived2 : Base { }


// class Some<T> where T : Base, new()
// {
// }




class Some<T, B> where T : B{}




interface IBase { }
interface IDerived1 : IBase { }
interface IDerived2 : IBase { }

class A : IDerived1 { }

// class Some<T> where T : Base, IBase, new()
// {
// 
// }







class Program
{
    static void Main()
    {
        Some<Derived1, Base> some = new();


        // Some<A> some = new();



        // Some<Base> some = new();




        // Base<Test> b = new();






        // SomeClass<string> some = new();
        // // some.Foo<string>();
        // some.Foo();



        // some.Serialize<int>(42);
        // some.Serialize(42);



        // // SomeClass<int> some = new SomeClass<int>();
        // SomeClass<string> some = new();
        // some.Data = "Hello";
        // Console.WriteLine(some.Data);

    }


}