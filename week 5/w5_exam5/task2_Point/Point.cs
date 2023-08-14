namespace task2_Point
{
    public class Point
    {
        int x=0;
        int y=0;
        public Point(){}
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX() => x;
        public int SetX(int x) =>this.x=x;
        public int GetY()=>y;
        public int SetY(int y) =>this.y=y;
        public override string ToString() => $"({x},{y})";
        public int[] GetXY() => new int[2] { x, y };
        public void SetXY(int x, int y) { 
            this.x=x; this.y=y;
        }
        public double Distance(int x, int y)=>Math.Sqrt(Math.Pow((x-this.x),2)+Math.Pow((y-this.y),2));
        public double Distance(Point another) => Math.Sqrt(Math.Pow((another.GetX() - this.x), 2) + Math.Pow((another.GetY() - this.y), 2));
        public double Distance() => 0;  

    }
}
