int a1 = 23;
int b1 = 38;
int c1 = 55;
int a2 = 29;
int b2 = 36;
int c2 = 59;
int a3 = 24;
int b3 = 68;
int c3 = 11;

int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if (arg2 > result) result = arg2;
if (arg3 > result) result = arg3;
return result;
}

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);