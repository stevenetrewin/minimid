public class Task
{
    private int _id;
    private string _name;
    private string _description;
    private DateTime _deadline;

    public Task(int id, string name, string description, DateTime deadline)
    {
        _id = id;
        _name = name;
        _description = description;
        _deadline = deadline;
    }

    // You might also want to include properties to access these fields.
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public DateTime Deadline
    {
        get { return _deadline; }
        set { _deadline = value; }
    }
}
