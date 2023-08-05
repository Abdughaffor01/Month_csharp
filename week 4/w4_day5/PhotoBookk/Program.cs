using PhotoBookk;

PhotoBook photo = new PhotoBook();
Console.WriteLine(photo.GetNumPage());
PhotoBook photo1 = new PhotoBook(24);
Console.WriteLine(photo1.GetNumPage());
BigPhotoBook photo2 = new BigPhotoBook();
Console.WriteLine(photo2.GetNumPage());