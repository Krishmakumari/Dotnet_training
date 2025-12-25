using System;

public class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public int numPages { get; set; }
    public DateTime dueDate { get; set; }
    public DateTime returnedDate { get; set; }

    public Book()
    {

    }
    public Book(string t,string a, int nP,DateTime dDate, DateTime rDate)
    {
        this.title=t;
        this.author=a;
        this.numPages=nP;
        this.dueDate=dDate;
        this.returnedDate=rDate;
    }

    public double AveragePagesReadPerDay(int daysToRead)
    {
        return (numPages/daysToRead);
    }

    public double CalculateLateFee(double dailyLateFeeRate)
    {
        double noOfDaysLate=(returnedDate - dueDate).Days;
        double lateFee= noOfDaysLate * dailyLateFeeRate;
        return lateFee;
    }

}