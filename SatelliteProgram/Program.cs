using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Satellite
{
  public class Commands : WebSocketBehavior
  {
    protected override void OnMessage (MessageEventArgs e)
    {
        if (e.Data.StartsWith("COMMAND"))
        {
            // if(trusted)
                var msg = "running";
                //output orbital change request
            // else 
                // waiting for second confirmation or one time pass 
            
        }else if(e.Data.StartsWith("SECONDREQUEST")){
            var msg = "SECOND intercept {sat name} {time}";
        }else if(e.Data.StartsWith("SECONDRESPONSE")){
            // if(confimed) 
            //      take action ordered
            // else
            //      reject and degrade trust model 
        } else if(e.Data.StartsWith("GROUNDCONNECTED")){
            //tell ground if any actions failed
            // add connection to trust model
        }
      Send (msg);
    }
  }

  public class Program
  {
    public static void Main (string[] args)
    {
      var wssv = new WebSocketServer ("ws://localhost:1234");
      wssv.AddWebSocketService<Commands> ("/Commands");
      wssv.Start ();
      Console.ReadKey (true);
      wssv.Stop ();
    }
  }
}