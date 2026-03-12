using System;

    public class MediSure
    {
        public string BillId { get; set; }
        public string PatientName { get; set; }
        public string HasInsurance { get; set; }
        public float ConsultationFee { get; set; }
        public float LabCharges { get; set; }
        public float MedicineCharges { get; set; }

        static MediSure LastBill;
        bool HasLastBill=false;
        float DiscountAmount=0;
        float GrossAmount=0;
        double FinalPayable=0;


        public void Register()
        {
            System.Console.WriteLine("Enter Bill Id: ");
            BillId=Console.ReadLine();

            System.Console.WriteLine("Enter Patient Name: ");
            PatientName=Console.ReadLine();

            System.Console.WriteLine("Is the patient insured? (Y/N)");
            HasInsurance=Console.ReadLine();

            System.Console.WriteLine("Enter Consultation fee: ");
            ConsultationFee=float.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Lab Charges: ");
            LabCharges=float.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter Medicine Charges: ");
            MedicineCharges=float.Parse(Console.ReadLine());

            System.Console.WriteLine("Bill Created Successfully");

            GrossAmount=ConsultationFee+LabCharges+MedicineCharges;
            System.Console.WriteLine("Gross Amount: "+GrossAmount);

            if(HasInsurance=="Y")
            {
                DiscountAmount=GrossAmount* 0.10f;
            }
            System.Console.WriteLine("Discount Amount: "+DiscountAmount);

            FinalPayable=GrossAmount-DiscountAmount;
            System.Console.WriteLine("Final Payable: "+FinalPayable);

            HasLastBill=true;
            LastBill=this;
        }

        public void View()
        {
            if(HasLastBill)
            {
                System.Console.WriteLine("--------Last Bill---------");
                System.Console.WriteLine("BillID: "+LastBill.BillId);
                System.Console.WriteLine("Patient: "+LastBill.PatientName);
                System.Console.WriteLine("Insured: "+LastBill.HasInsurance);
                System.Console.WriteLine("Consultation Fee: "+LastBill.ConsultationFee);
                System.Console.WriteLine("Lab Charges: "+LastBill.LabCharges);
                System.Console.WriteLine("Medicine Charges: "+LastBill.MedicineCharges);
                System.Console.WriteLine("Gross Amount: "+LastBill.GrossAmount);
                System.Console.WriteLine("Discount Amount: "+LastBill.DiscountAmount);
                System.Console.WriteLine("Final Payable: "+LastBill.FinalPayable);
                System.Console.WriteLine("----------------------------");


            }
            else
            {
                System.Console.WriteLine("No bill available. Please create a new bill first.");
            }
        }

        public void Clear()
        {
            HasLastBill=false;
            LastBill=null;
            System.Console.WriteLine("Last Bill cleared");
        }



    }
