<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Reactive.Threading.Tasks</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

var client = new HttpClient();
client.GetStringAsync("http://www.example.com").ToObservable()
.Timeout(System.TimeSpan.FromSeconds(1))
.Subscribe(x => Console.WriteLine($"{DateTime.Now.Second} : Saw {x.Length}"),
ex => Console.WriteLine(ex));
