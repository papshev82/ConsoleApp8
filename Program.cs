Console.Write("введите число n:");
int n=int.Parse(Console.ReadLine());
int a =n/1000;
int b =n%1000/100;
int c= n%100/10;
int d=n%10;
Console.WriteLine ($"Сумма цифр:{a+b+c+d}");
Console.WriteLine ($"Произведение цифр:{a*b*c*d}");