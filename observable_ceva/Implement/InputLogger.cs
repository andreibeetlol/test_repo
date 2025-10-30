public class InputLogger
{
    public string Log { get; private set; } = "";

    public void AddLog(string log)
    {
        Log += $"{DateTime.UtcNow}: {log}\r\n";
    }
}