namespace Day4OOPDemo
{
    class Manager:Employee
    {
        public int MgrID { get; set; }
        public int Incentive { get; set; }

        public int CalculateSalary(int sal)
        {
            int mySal=0;
            // Net Salary = salary+HRA+TA+DA+PF
            mySal=(sal+25000+8000+4500-8500);
            return mySal;
        }
    }
}