using System;

public class Admission
{
    public static void AdmissionMain()
    {
        Console.WriteLine("Enter Maths marks: ");
        int maths=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Phy marks: ");
        int phy=Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Chem marks: ");
        int chem=Int32.Parse(Console.ReadLine());

        int mp=maths+phy;
        int t=maths+phy+chem;
        if((maths>=65 && phy>=55 && chem>=50) && (t>=180 || mp>=140)){
            Console.WriteLine("Eligible for Admission");
        }else{
            Console.WriteLine("Not Eligible");
        }

    }
}