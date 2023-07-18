System.Console.WriteLine();

Date date=new Date(25,07,2001);
Console.WriteLine("Year :"+date.GetYear());
Console.WriteLine("Month:"+date.GetMonth());
Console.WriteLine("Day  :"+date.GetDay());
date.SetYear(2005);
date.SetMonth(5);
date.SetDay(28);
System.Console.WriteLine(date.toString());
date.setDate(29,12,2001);
System.Console.WriteLine(date.toString());
System.Console.WriteLine();