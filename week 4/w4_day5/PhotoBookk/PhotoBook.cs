namespace PhotoBookk;

public class PhotoBook
{
   protected int numPage;
   public virtual int GetNumPage() => numPage;
   public PhotoBook() => numPage = 16;
   public PhotoBook(int numPage) => this.numPage = numPage;
}
