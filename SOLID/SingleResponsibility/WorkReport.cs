namespace SOLID.SingleResponsibility
{
    public class WorkReport: IEntryManager<WorkEntry>
    {
        private readonly List<WorkEntry> _entries;

        public WorkReport()
        {
            _entries = new();
        }

        public void AddEntry(WorkEntry entry) => _entries.Add(entry);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);


        public override string ToString() => 
            string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hourse: {x.SpentHours}"));
    }
}
