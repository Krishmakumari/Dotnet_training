// See https://aka.ms/new-console-template for more information

using Day2DemoConsole;
static void Menu()
{
    System.Console.WriteLine("1 add student details");
    System.Console.WriteLine("1 update student details");
    System.Console.WriteLine("1 drop student details");
}

Console.WriteLine("Hello, World!");

Student sobj=new Student(123,"Alok","Chennai");

sobj.DisplayDetails(sobj);
sobj=new Student(123,"Alok","Chennai");
sobj.DisplayDetails(sobj);

string[] cities={"pune","Chennai","Agra","Amritsar","Mumbai"};

int i=0;
foreach(var item in cities)
{
    System.Console.WriteLine(item);
}

while(i<cities.Length)
{
    System.Console.WriteLine(cities[i]);
    i++;
}

//switch case
int choice=0;
do{
    Menu();
    System.Console.WriteLine("Enter your choice");
    choice=Int32.Parse(Console.ReadLine());
    switch(choice)
    {
        case 1:
        {
            break;
        }
        case 2:
        {
            break;
        }
        case 3:
        {
            break;
            return;
        }

    }
}while(true);