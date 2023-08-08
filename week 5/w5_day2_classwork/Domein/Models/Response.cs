namespace Domein.Models;
public class Response<T>
{
   public string Message { get; set; }
   public T Data { get; set; }
   public Response(string message) => Message = message;
   public Response(string message, T data)
   {
      Message = message;
      Data = data;
   }
}
