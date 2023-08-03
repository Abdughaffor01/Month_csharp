namespace Bank
{
   public class IDGENERATOR
   {
      static int id = 0;
      string storeId;
      public string generate()
      {
         string gid = DateTime.Now.ToString("yyyy-MM-");
         storeId = gid + ++id;
         return storeId;
      }
   }
}
