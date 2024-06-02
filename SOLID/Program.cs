using SOLID.SingleResponsibility;
using SOLID.SingleResponsibility.Scheduler;

namespace Solid;
public class Program
{
    private static void Main()
    {
       WorkReport report = new();
        report.AddEntry(new WorkEntry { ProjectCode = "345A4", ProjectName = "Project1", SpentHours = 3 });
        report.AddEntry(new WorkEntry { ProjectCode = "61SVX", ProjectName = "Project2", SpentHours = 2 });

        Console.WriteLine(report.ToString());

        Scheduler scheduler = new();
        scheduler.AddEntry(new ScheduleTask { TaskID = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
        scheduler.AddEntry(new ScheduleTask { TaskID = 2, Content = "Don't forget to...", ExecuteOn = DateTime.Now.AddDays(2) });

        Console.WriteLine(scheduler.ToString());

        FileSaver fileSaver = new();
        fileSaver.SaveToFile(@"Report", "WorkReport.txt", report);
        fileSaver.SaveToFile(@"Schedulers", "Schedule.txt", scheduler);
    }
}