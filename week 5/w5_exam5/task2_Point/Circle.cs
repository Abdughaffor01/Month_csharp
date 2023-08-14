namespace task2_Point
{
    public class Circle
    {
        Point center=new Point();
        double radius=1.0;
        const double pi= 3.14;
        public Circle(int xcenter,int ycenter,double radius)
        {
            center.SetX(xcenter);
            center.SetY(ycenter);
            this.radius = radius;
        }
        public Circle(Point center,double radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public double GetRadius() => radius;
        public void SetRadius(double radius)=>this.radius = radius;
        public Point GetCenter() => center;
        public void SetCenter(Point center)=>this.center = center;
        public int GetCenterX()=>center.GetX();
        public void SetCenterX(int x)=>this.center.SetX(x);
        public int GetCenterY() => center.GetY();
        public void SetCenterY(int y) => this.center.SetY(y);
        public int[] GetCenterXY() => center.GetXY();
        public void SetCenterXY(int x, int y)
        {
            this.center.SetX(x);
            this.center.SetY(y);
        }
        public override string ToString() => $"Circle[center=({center.GetX()},{center.GetY()}),radius={radius}]";
        public double GetArea() => pi * radius * radius;
        public double GetCircumference() => pi * radius * 2;
        public double Distance(Circle another)=>Math.Sqrt(Math.Pow((another.GetCenterX() -center.GetX()), 2) + Math.Pow((another.GetCenterY() - center.GetY()), 2));
    }
}
