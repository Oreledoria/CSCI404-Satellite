using System;
using WebSocketSharp;
using System.Threading;
namespace Ground
{
  public class Program
  {
    public static void Main (string[] args)
    {
      using (var ws = new WebSocket ("ws://localhost:1234/Commands")) {
        ws.OnMessage += (sender, e) =>
            Console.WriteLine ("Commands says: " + e.Data);

        ws.Connect ();
        ws.Send ("BALUS");
        Thread.Sleep(25);
      }
    }
  }
}