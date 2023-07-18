// 1 zadacha
// int s = Convert.ToInt32(Console.ReadLine());
// int h = (s / 3600) % 24, m = (s % 3600) / 60, c = (s % 3600) % 60;
// Console.WriteLine($"{h}:{m / 10}{m % 10}:{c / 10}{c % 10}");

// 2 zadacha
// int ms = Convert.ToInt32(Console.ReadLine()), md = Convert.ToInt32(Console.ReadLine()),
// shs = Convert.ToInt32(Console.ReadLine()), shd = Convert.ToInt32(Console.ReadLine());
// int narh = ms * 100 + md, pul = shs * 100 + shd, bakiya = pul - narh;
// Console.WriteLine($"{bakiya / 100} {bakiya % 10}");

// 3 zadacha
// int oylka = Convert.ToInt32(Console.ReadLine()), staj = Convert.ToInt32(Console.ReadLine());
// if (staj >= 5) Console.WriteLine(oylka + oylka * 5 / 100);
// else Console.WriteLine(oylka);

// 4 zadacha
// int faq(int a)
// {
//    int b = 1;
//    for (int i = 1; i <= a; i++) b *= i;
//    return b;
// }
// int n = Convert.ToInt32(Console.ReadLine()), k = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(faq(n) / (faq(k) * (faq(n - k))));

// 5 zadacha
// int faq(int a)
// {
//    int b = 1;
//    for (; a > 0; a--) b *= a;
//    return b;
// }
// double SumOfFactorial(int n)
// {
//    double sum = 1;
//    for (int i = 1; i <= n; i++) sum += 1 /(double) faq(i);
//    return sum;
// }
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumOfFactorial(n));

//6 zadacha
// int EvenCount(int n)
// {     //1. Количество четных чисел
//    int cnt = 0;
//    for (; n > 0; n/=10) if ((n % 10)%2 == 0) cnt++;
//    return cnt;
// }
// int OddCount(int n)
// {  //2. Количество нечетных чисел
//    int cnt = 0;
//    for (; n > 0; n/=10) if ((n % 10)%2 == 1) cnt++;
//    return cnt;
// }
// int DigitCount(int n)
// {    //3. Количество цифр.
//    int cnt = 1;
//    for (; n > 9; n /= 10) cnt++;
//    return cnt;
// }
// int SumDigit(int n)
// {       //4. Сумма цифр.
//    int sum = 0;
//    for (; n > 0; n /= 10) sum += n % 10;
//    return sum;
// }
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Количество четных чисел: {EvenCount(b)}");
// Console.WriteLine($"Количество нечетных чисел: {OddCount(b)}");
// Console.WriteLine($"Количество цифр.: {DigitCount(b)}");
// Console.WriteLine($"Сумма цифр: {SumDigit(b)}");

//7 zadacha
// int b = Convert.ToInt32(Console.ReadLine()), snt = 0;
// int[] arr = new int[b];
// for (int i = 0; i < b; i++)arr[i] = Convert.ToInt32(Console.ReadLine());
// for (int i = 2; i < b; i++) if (arr[i - 1] > arr[i - 2] && arr[i - 1] > arr[i]) snt++;
// Console.WriteLine("Kolvo = " + snt);


//8 zadacha
// int b = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[b];
// for (int i = 0; i < b; i++)arr[i] = Convert.ToInt32(Console.ReadLine());
// Array.Sort(arr);
// Array.Reverse(arr);
// for (int i = 0; i < b; i++) Console.Write(arr[i]+" ");

//9 zadacha
// int b = Convert.ToInt32(Console.ReadLine()),max=-999999,index=0;
// int[] arr = new int[b];
// for (int i = 0; i < b; i++)arr[i] = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < b; i++) {
//    if(arr[i]>max){
//       max=arr[i];
//       index=i;
//    }
// }
// Console.WriteLine(index);

// 10 zadacha
// int b = Convert.ToInt32(Console.ReadLine()),min=999999;
// int[] arr = new int[b];
// for (int i = 0; i < b; i++)arr[i] = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < b; i++) {
//    if(arr[i]<min) min=arr[i];
// }
// System.Console.WriteLine(min);

// 11 zadacha
// int b = Convert.ToInt32(Console.ReadLine()),max=-999999;
// int[] arr = new int[b];
// for (int i = 0; i < b; i++)arr[i] = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < b; i++) {
//    if(arr[i]>max) max=arr[i];
// }
// System.Console.WriteLine(max);

// 12 zadacha
// int b = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[b];
// for (int i = 0; i < b; i++)arr[i] = Convert.ToInt32(Console.ReadLine());
// int x = Convert.ToInt32(Console.ReadLine()),cnt=0;
// for (int i = 0; i < b; i++) {
//    if(arr[i]==x)cnt++;   
// }
// Console.WriteLine(cnt);

// 13 zadacha
// int b = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[b];
// for (int i = 0; i < b; i++)arr[i] = Convert.ToInt32(Console.ReadLine());
// int x = Convert.ToInt32(Console.ReadLine()),cnt=0;
// for (int i = 0; i < b; i++) {
//    if(arr[i]==x) cnt++;
// }
// if(cnt>0)Console.WriteLine("YES");
// else Console.WriteLine("NO");
