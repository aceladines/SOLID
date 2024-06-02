namespace SOLID.SingleResponsibility.Scheduler
{
    public class ScheduleTask
    {
        public long TaskID { get; set; }
        public string Content { get; set; }
        public DateTime ExecuteOn { get; set; }
    }
}
