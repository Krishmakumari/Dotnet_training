namespace Day4OOPDemo
{
    class Employee
    {
        #region Properties
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int BasicSal { get; set; }
        #endregion

        public int CalculateSalary(int sal)
        {
            int mySal=0;
            // Net Salary = salary+HRA+TA+DA+PF
            mySal=(sal+15000+3000+1500-2500);
            return mySal;
        }
    }
    
}