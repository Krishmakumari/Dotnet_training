using System;

namespace FactoryRobotHazardAnalyzer
{
    internal class RobotHazardAuditor
    {
        public double GetMachineRiskFactor(string machineryState)
        {
            if (machineryState == "Worn") return 1.3;
            if (machineryState == "Faulty") return 2.0;
            if (machineryState == "Critical") return 3.0;
            return 0.0;
        }

        public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
            if (armPrecision < 0.0 || armPrecision > 1.0)
            {
                throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
            }

            if (workerDensity < 1 || workerDensity > 20)
            {
                throw new RobotSafetyException("Error: Worker density must be 1-20");
            }

            if (machineryState != "Worn" && machineryState != "Faulty" && machineryState != "Critical")
            {
                throw new RobotSafetyException("Error: Unsupported machinery state");
            }

            double hazardRisk =
                ((1.0 - armPrecision) * 15.0) +
                (workerDensity * GetMachineRiskFactor(machineryState));

            return hazardRisk;
        }
    }
}
