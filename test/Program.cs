 
B obj2 = new B();
obj2.Foo();
 
A obj3 = new B();
obj3.Foo();
class A
{
    public virtual void Foo()
    {
        Console.WriteLine("Class A");
    }
}
class B: A
{
    public override void Foo()
    {
        Console.WriteLine("Class B");
    }
}

// List<Action> actions = new List<Action>();
// for(var count=0; count<10; count++)
// {
//     actions.Add(() => Console.WriteLine(count));
// }
// foreach(var action in actions)
// {
//     action();
//     System.Console.WriteLine(action);
// }
// int i = 1;
// object obj = i;
// ++i;
// Console.WriteLine(i);
// Console.WriteLine(obj);
// Console.WriteLine((short)obj);