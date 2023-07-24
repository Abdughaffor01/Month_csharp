using task1.Time;

Time time1=new Time(12,54,54);
time1.print();
time1.nextSecond().nextSecond();
time1.print();
Console.WriteLine();

Time time=new Time();
time.print();
Console.Write(time.getHour()+" ");
Console.Write(time.getMinute()+" ");
Console.WriteLine(time.getSecond()+" ");
time.setHour(6);
time.setMinute(10);
time.setSecond(10);
time.print();
Console.WriteLine(time.toString());
time.setTime(12,56,43); 
time.print();
time.nextSecond().nextSecond();
time.print();


