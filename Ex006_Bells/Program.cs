﻿// See https://aka.ms/new-console-template for more information
int a = 1;
int b = 6;
int c = 8;
int d = 4;
int e = 3;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write("max = ");
Console.WriteLine(max);