// 1
// int FindMinimum (int a, int b, int c, int d){
//    int min=99999;
//    if(a<min)min=a;
//    if(b<min)min=a;
//    if(c<min)min=a;
//    if(d<min)min=a;
//    return min;
// }
// System.Console.WriteLine(FindMinimum(-9,5,67,8));

// 2
// int n=Convert.ToInt32(Console.ReadLine());
// string[] names=new string[n];
// for (int i = 0; i < n; i++)names[i]=Console.ReadLine();
// foreach (var e in names)
// {
//    Console.WriteLine(e);
//    Console.WriteLine();
// }

// 3
// int n = Convert.ToInt32(Console.ReadLine());
// int[] sosed = new int[n];
// for (int i = 0; i < n; i++) sosed[i] = Convert.ToInt32(Console.ReadLine());
// if (n % 2 == 0)
// {
//    for (int i = 1; i < n; i += 2)
//    {
//       int c = sosed[i];
//       sosed[i]=sosed[i-1];
//       sosed[i-1]=c;
//    }
// }else{
//    for (int i = 1; i < n-1; i += 2)
//    {
//       int c = sosed[i];
//       sosed[i]=sosed[i-1];
//       sosed[i-1]=c;
//    }
// }
// System.Console.WriteLine();
// foreach (var e in sosed)System.Console.Write(e+" ");

// 4
// int n = Convert.ToInt32(Console.ReadLine()),cnt=1;
// int[] raz = new int[n];
// for (int i = 0; i < n; i++) raz[i] = Convert.ToInt32(Console.ReadLine());
// Array.Sort(raz);
// for (int i = 1; i < n; i++)
// {
//    if(raz[i]!=raz[i-1])cnt++;
// }
// System.Console.WriteLine();
// System.Console.WriteLine(cnt);

// 5
// int n = Convert.ToInt32(Console.ReadLine()), min = 999999, max = -999999, imn = 0, imx = 0;
// int[] mej = new int[n];
// for (int i = 0; i < n; i++) mej[i] = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < n; i++)
// {
//    if (mej[i] < min)
//    {
//       min=mej[i];
//       imn = i;
//    }
//    if (mej[i] > max)
//    {
//       max=mej[i];
//       imx = i;
//    }
// }
// if (imx > imn)for (int i = imn; i <=imx; i++)Console.Write(mej[i]+" ");
// else for (int i = imx; i <=imn; i++)Console.Write(mej[i]+" ");

// 6
// int N = Convert.ToInt32(Console.ReadLine());
// double sum=0;
// for (int i = 0; i <= N; i++)
// {
//    sum+=Math.Pow(2,i);
// }
// System.Console.WriteLine(sum);


// 7
// Класс гуфта  накшаеро меноманд ки хангоми сохтан метонем аз у истифода бурда 
// як чанд объект созен
// мисол: накшаи macbook аз як накша милион милион macbook дар дунё истифода мекунанд;
// Яъне класс накша ва объект ин натича аз накша мебошад;