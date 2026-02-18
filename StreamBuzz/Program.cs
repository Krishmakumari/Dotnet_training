public class Program
{
    public  void RegisterCreator(CreatorStats record)
    {
        CreatorStats.EngagementBoard.Add(record);
    }

    public  Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string,int> result=new Dictionary<string, int>();
        foreach (var creator in records)
        {
            int cnt=creator.WeeklyLikes.Count(like=>like>=likeThreshold);

            if(cnt>0)
            {
                result.Add(creator.CreatorName,cnt);
            }
        }
        return result;
    }

    public double CalculateAverageLikes()
    {
        double totalLikes=0;
        double week=0;

        foreach (var creator in CreatorStats.EngagementBoard)
        {
            totalLikes+=creator.WeeklyLikes.Sum();
            week+=creator.WeeklyLikes.Length;
        }
        return totalLikes/week;
    }

    public static void Main()
    {
        Program p=new Program();
        CreatorStats cObj1=new CreatorStats
        {
            CreatorName="Roma",
            WeeklyLikes=new double[]{1500,1600,1800,2000}
        };
        CreatorStats cObj2=new CreatorStats
        {
            CreatorName="Nicky",
            WeeklyLikes=new double[]{800,100,800,1200}
        };

        p.RegisterCreator(cObj1);
        p.RegisterCreator(cObj2);

        Console.WriteLine("Creator added succesfully\n");

        double threshHold=1400;
         Console.WriteLine("Top Posts (Threshold: 1400)");

         var topPosts=p.GetTopPostCounts(CreatorStats.EngagementBoard,threshHold);

        if(topPosts.Count()==0)
        {
            Console.WriteLine("No top-performing posts this week");
        }
        else
        {
            foreach (var item in topPosts)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }
        }

        double avg=p.CalculateAverageLikes();
        Console.WriteLine("Avg likes: "+avg);



    }
}