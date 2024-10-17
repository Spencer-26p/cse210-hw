class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name,topic)
    {
        _title = title;
    }
    public string GetWrtiingInformation()
    {
        return _title + " by " + GetStudentName();
    }
}