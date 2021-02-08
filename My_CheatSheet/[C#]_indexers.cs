public class HTtpCookie 
{
    public readonly Dictionary<string,string> _dict { get; set; }
    public DateTime Expiry { get; set; }

    public HTtpCookie()
    {
        _dict = new Dictionary<string, string>();

    }

    public string this[string key]
    {
        get{ return _dict[key]; }
        set { _dict[key] = value; }
    }
}
