namespace Firebase___example_app;
public class Notification
{
    public Message message { get; set; }
}
public class Message
{
    public string to { get; set; }
    public Data notification { get; set; }

}
public class Data
{
    public string title { get; set; }
    public string body { get; set; }
}
