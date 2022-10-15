<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

var client = new WebClient();
var downloadedStrings = Observable.FromEventPattern(client, "DownloadStringCompleted");
downloadedStrings.Subscribe(data =>
{
	var eventArgs = (System.Net.DownloadStringCompletedEventArgs)data.EventArgs;
	if (eventArgs.Error != null)
	{
		Console.WriteLine($"OnNext:(Error) {eventArgs.Error}");
	}
	else
	{
		Console.WriteLine($"OnNext: {eventArgs.Result}");
	}
},
ex => Console.WriteLine($"OnError:{ex.ToString()}"),
() => Console.WriteLine("OnCompleted")
);
client.DownloadStringAsync(new Uri("http://invalid.example.com/"));