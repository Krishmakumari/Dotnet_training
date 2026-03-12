using System;

namespace FactoryRobotHazardAnalyzer
{
    class RobotSafetyException : Exception
    {
        public RobotSafetyException(string message) : base(message)
        {
        }
    }
}
