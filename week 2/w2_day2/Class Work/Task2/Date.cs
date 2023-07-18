public class Date{
   int _day;
   int _month;
   int _year;
   public Date(int day,int month,int year){
      if((day<1 || day >31) || (month <1 || month >12) || (year <1000 ||  year>9999)){
         System.Console.WriteLine("Пожалуиста введите верни информации");
      }else{
         _day=day;
         _month=month;
         _year=year;
      }
   }
   public int GetYear(){
      return _year;
   }
   public int GetMonth(){
      return _month;
   }
   public int GetDay(){
      return _day;
   }
   public void SetYear(int year){
      _year=year;
   }
   public void SetMonth(int month){
      _month=month;
   }
   public void SetDay(int day){
      _day=day;
   }
   public string toString(){
      return $"{_month}/{_day}/{_year} with leading zero";
   }
   public void setDate(int day,int month,int year){
      if((day<1 || day >31) || (month <1 || month >12) || (year <1000 ||  year>9999)){
         System.Console.WriteLine("Пожалуиста введите верни информация");
      }else{
         _day=day;
         _month=month;
         _year=year;
      }
   }
}