namespace PhotoBookk;

public class BigPhotoBook : PhotoBook
{
   public BigPhotoBook() => base.numPage = 64;
   public BigPhotoBook(int numPage) => base.numPage = numPage;
   public override int GetNumPage() => base.numPage;
}
