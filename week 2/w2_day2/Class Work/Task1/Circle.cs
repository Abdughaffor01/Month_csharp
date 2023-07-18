public class Circle{
   double _radius;
   string _color;
   public Circle(double radius,string color){
      _radius=radius;
      _color=color;
   }
   public double GetRadius(){
      return _radius;
   }
   public string GetColor(){
      return _color;
   }
   const double pi=3.14f;
    public Double GetArea(){
      return pi*_radius*_radius;
   }
}