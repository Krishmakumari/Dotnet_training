namespace LPU_Exceptions
{
    /// <summary>
    /// Custom Exception class created for LPU Project
    /// by Krishma on Date 29/12/2025 at 11:34 AM
    /// </summary>
    public class LpuException : Exception
    {
        public LPU_Exception() : base()
        {

        }

        public LPU_Exception(string errorMsg) :base(errorMsg)
        {

        }
    }
}
