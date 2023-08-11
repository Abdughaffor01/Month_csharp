namespace Students.Service;

public class Response<T>
{
   public string Message { get; set; }
   public T Data { get; set; }
   public Response(string Message) => this.Message = Message;
   public Response(string Message, T Data)
   {
      this.Message = Message;
      this.Data = Data;
   }
}
