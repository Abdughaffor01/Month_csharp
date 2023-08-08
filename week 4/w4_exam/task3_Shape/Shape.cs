namespace task3_Shape;
public abstract class Shape
{
   public Enum Color { get; set; }
   protected bool filled=true;
   public Shape(){}
   public Shape(Enum color,bool filled){
      Color = color;
      this.filled = filled;
   }
   public Enum GetColor()=>Color;
   public Enum SetColor(Enum color) =>this.Color=color;
   public abstract double GetArea();
   public abstract double GetPerimeter();
   public override string ToString()=>$"Shape [color={Color} ,filled={filled}]";
}
