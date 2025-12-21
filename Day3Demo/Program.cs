// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int x=100;
float a=x; //implicit conversion - from lower datatype to higher 

short y= (short)x; //explicit conversion - from higher to lower, so use type conversion

//boxing and unboxing

int num=120;

object op=num; //boxing - val to ref

int nums=(int) op; //unboxing - ref to value