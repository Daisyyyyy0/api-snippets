// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class Example
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Auth Token at twilio.com/console
        // To set up environmental variables, see http://twil.io/secure
        const string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        const string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");
        TwilioClient.Init(accountSid, authToken);

        var messages = MessageResource.Read(
            to: new PhoneNumber("+15558675310"),
            from: new PhoneNumber("+15017122661"),
            dateSentAfter: new DateTime(2016, 8, 31));

        foreach (var message in messages)
        {
            Console.WriteLine(message.Body);
        }
    }
}
