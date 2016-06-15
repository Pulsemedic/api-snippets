// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio;
class Example 
{
  static void Main(string[] args) 
  {
    // Find your Account Sid and Auth Token at twilio.com/user/account
    string AccountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    string AuthToken = "your_auth_token";
    string WorkspaceSid = "WSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    var client = new TaskRouterClient(AccountSid, AuthToken);

    Workspace workspace = client.AddWorkspace("NewWorkspace", "http://requestb.in/vh9reovh", "FIFO");
    Console.WriteLine(workspace.FriendlyName);
  }
}