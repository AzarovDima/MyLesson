int a = 5;
int b = 34;
int c = 21;
int d = 42;
int e = 46;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write($"Максимальное число равняется {max}");