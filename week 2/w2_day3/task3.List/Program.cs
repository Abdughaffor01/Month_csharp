// // 1
// List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
// int sum=0;
// foreach (var i in numbers)sum+=i;
// Console.WriteLine("Сумма всех чисел = "+sum);


// 2
// List<string> words = new List<string>{ "hello", "world", "!" };
// string name = string.Join(" ", words);
// Console.WriteLine("The concatenated string is: " + name);


// // 3
// List<DateTime> dates = new List<DateTime>
// {
// new DateTime(2020, 10, 1),
// new DateTime(2022, 8, 15),
// new DateTime(2021, 4, 28)
// };
// dates.Sort();
// foreach (DateTime date in dates)
// {
//    Console.WriteLine(date.ToShortDateString());
// }

// // 4
// List<double> numbers = new List<double>{ 3.5, 2.7, 6.9, 1.2 };
// double average=0;
// foreach (var i in numbers) average+=i;
// Console.WriteLine("The average value of all the elements in the list is: " + average);

// // 5
// List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
// FindAll(numbers);
// void FindAll(List<int> l){
//    foreach (var i in l)Console.WriteLine(i);
// }

// // 6
// List<bool> values = new List<bool>{ true, false, true };
// string otvet=All(values);
// string All(List<bool> l){
//    int cnt=0;
//    foreach (var i in l) if(i==true)cnt++;
//    if(cnt==l.Count()) return "alltrue"; 
//    return "noalltrue";
// }
// Console.WriteLine("Are all the values in the list true? " + otvet);

// 7
// Random r=new Random();
// List<int> l = new List<int>();

// for (int i = 0; i < 5; i++)
// {
//    l.Add(r.Next());
// }
// foreach (var i in l)
// {
//    System.Console.WriteLine(i);
// }
