public  class Paint
{
   int x;
   int y;
   public Paint() { }
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
   public string Distance(int x, int y)
   {
      this.x -= x;
      this.y -= y;
      return $"({x},{y})";
   }
   public string Distance(Paint another)
   {
      double xx = this.x - another.x;
      double yy = this.y - another.y;
      return $"({xx},{yy})";
   }
   public string Distance()
   {
      return $"({0},{0})";
   }
}
