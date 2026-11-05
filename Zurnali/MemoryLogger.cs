public class MemoryLogger : ILogger, ILogReader
{
    private readonly List<string> _messages = new List<string>();

    public void Log(string message)
    {
        _messages.Add(message);
    }

    public List<string> GetMessages()
    {
        return _messages;
    }
}