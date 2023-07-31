public class Book : Author
{
   string name;
   Author author;
   double price;
   int quantity;
   public Book(string name, Author author, double price, int quantity, string nameauthor, string email, char s) : base(nameauthor, email, s)
   {
      this.name = name;
      this.author = author;
      this.price = price;
      this.quantity = quantity;
   }
   public string GetName()=> name;
   public Author GetAuthor()=> author;
   public double GetPrice()=> price;
   public void SetPrice(double price)=> this.price=price;
   public int GetQuat()=> quantity;
   public void SetQuat(int quantity)=> this.quantity=quantity;
   
   public override string ToString()=> $"'{name}' by {base.ToString()}";

}