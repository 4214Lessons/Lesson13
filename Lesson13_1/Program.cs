namespace Lesson13_1;

#nullable disable


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}


class Program
{
    static void DoSomething(Action<Student> action)
    {
        var st = new Student();
        action.Invoke(st);

        Console.WriteLine(st.Id);
        Console.WriteLine(st.Name);
        Console.WriteLine(st.Surname);
    }

    static void Main()
    {
        DoSomething(s =>
        {
            s.Id = 1;
            s.Name = "Leyla";
            s.Surname = "Shefiyeva";
        });
    }
}