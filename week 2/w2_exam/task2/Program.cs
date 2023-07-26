void Numbers(int x,int y){
   for (int i = x; i <= y; i++)
   {
      for (int j = 1; j <= 10; j++)
      {
         Console.WriteLine($"{i} x {j} = {i*j}");
      }
      Console.WriteLine();
   }
}

Numbers(2,8);