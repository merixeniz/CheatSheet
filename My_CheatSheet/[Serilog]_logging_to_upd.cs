//to consume logs use Log2Console
//https://github.com/Statyk7/log2console
using Serilog.Sinks.Udp
// configure logger :
  Log.Logger = new LoggerConfiguration()
                .WriteTo.File("C:\\atut\\application-logs.txt")
                .WriteTo.Udp("127.0.0.1",20000,System.Net.Sockets.AddressFamily.InterNetwork, new Log4jTextFormatter())
                .CreateLogger();