public class Line : Paint
{
   Paint begin;
   Paint end;
   public Line(Paint begin, Paint end)
   {
      this.begin = begin;
      this.end = end;
   }
   public Line(int x1, int y1, int x2, int y2)
   {
      begin.SetX(x1);
      begin.SetY(y1);
      end.SetX(x2);
      end.SetY(y2);
   }
   public Paint GetBegin() => begin;
   public Paint SetBegin(Paint begin) => this.begin = begin;
   public Paint GetEnd() => end;
   public Paint SetEnd(Paint end) => this.end = end;
   public int GetBeginX() => begin.GetX();
   public void SetBeginX(int x) => begin.SetX(x);
   public int GetBeginY() => begin.GetY();
   public void SetBeginY(int y) => begin.SetY(y);
   public int[] GetBeginXY() => begin.GetXY();
   public void SetBeginXY(int x, int y) => begin.SetXY(x, y);

   public int GetEndX() => end.GetX();
   public void SetEndX(int x) => end.SetX(x);
   public int GetEndY() => end.GetY();
   public void SetEndY(int y) => end.SetY(y);
   public int[] GetEndXY() => end.GetXY();
   public void SetEndXY(int x, int y) => end.SetXY(x, y);

   public override string ToString()
   {
      return $"Line [begin=({begin.GetX()},{begin.GetY()}),end=({end.GetX()},{end.GetY()})]";
   }
}
