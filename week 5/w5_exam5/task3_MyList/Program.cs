
using task3_MyList;

MyList<int> list = new MyList<int>();
MyList<string> list1 = new MyList<string>();
list.Add(6);
list.Add(7);
list1.Add("hello");
list1.Add("ghaffor");
Console.WriteLine(list.ToString());
Console.WriteLine(list.Contains(6));
Console.WriteLine(list.Contains(10));
Console.WriteLine(list1.ToString());