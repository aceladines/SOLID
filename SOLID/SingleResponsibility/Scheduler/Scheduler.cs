namespace SOLID.SingleResponsibility.Scheduler
{
    public class Scheduler: IEntryManager<ScheduleTask>
    {
        private readonly List<ScheduleTask> _scheduleTasks;

        public Scheduler()
        {
            _scheduleTasks = new();
        }

        public void AddEntry(ScheduleTask scheduleTask) => _scheduleTasks.Add(scheduleTask);
        public void RemoveEntryAt(int index) => _scheduleTasks.RemoveAt(index);

        public override string ToString() =>
            string.Join(Environment.NewLine, _scheduleTasks.Select(x => $"Task with id: {x.TaskID} with content: {x.Content} is going to be executed on: {x.ExecuteOn}"));
    }
}       
