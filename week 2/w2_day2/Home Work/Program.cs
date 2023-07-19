int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
BirdCount b1=new BirdCount(birdsPerDay);
b1.LastWeek();
b1.IncrementTodaysCount();
b1.Today();
Console.WriteLine(b1.HasDayWithoutBirds());
b1.CountForFirstDays(4);
b1.BusyDays();