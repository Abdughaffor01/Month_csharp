Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
task1.Start();
Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));
Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));
Console.ReadLine();
