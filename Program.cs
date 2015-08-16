using System;
using Twilio;

namespace twiliosmsreceiver
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string AccountSID = "ACea7d95460837ce02f507680274e46dd4";
			string AuthToken = "{{ c7aa2968ee33a58e78d352610f014452 }}";

			var twilio = new TwilioRestClient (AccountSID, AuthToken);
			var message = twilio.SendMessage ("+13213207529", "+14439457390", "Ayyyyyyyy lmaooooooo", "");

			if (message.Sid != null) {
				Console.WriteLine (message.Body);
			}
		}
	}
}
