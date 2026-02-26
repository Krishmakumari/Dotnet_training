// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using FileHandlingDemo;

DirectoryDemo dObj = new DirectoryDemo();
//dObj.DirectoryDemoFunc("LPU");

//dObj.DriveInfoFunc("D:\\");


//dObj.PathDemo();

FileStreamDemo fsDemoObj = new FileStreamDemo();
//fsDemoObj.CreateFile(@"D:\Dotnet\FileHandlingDemo");

fsDemoObj.ReadFile(@"C:\Users\Admin\Downloads\front end_Interview_Feedback_Jul 25 2025.txt");