public  class Paint
{
   int x;
   int y;
   public Paint() {}
   public Paint(int x, int y)
   {
      this.x = x;
      this.y = y;
   }
   public int GetX() => x;
   public void SetX(int x) => this.x = x;
   public int GetY() => y;
   public void SetY(int y) => this.y = y;
   public override string ToString() => $"({x},{y})";
   public int[] GetXY()
   {
      int[] arr = new int[] { x, y };
      return (arr);
   }
   public void SetXY(int x, int y)
   {
      this.x = x;
      this.y = y;
   }
   public double Distance(int x, int y)
   {
     return Math.Sqrt(Math.Pow((x-this.x),2)+Math.Pow(y-this.y,2));
   }
   public double Distance(Paint another)
   {
      return Math.Sqrt(Math.Pow((another.x-this.x),2)+Math.Pow(another.y-this.y,2));
   }
   public string Distance()
   {
      return $"({0},{0})";
   }
}
