using System;

namespace InterfaceDemoProj
{
    interface IAdd
    {
        int AddMe(int num1,int num2); //abstract so no body
    }

    interface ISub
    {
        int SubME(int num1,int num2);
    }
    interface IProd
    {
        int ProdMe(int num1,int num2);
    }
    interface IDiv
    {
        int DivMe(int num1,int num2);
    }
}