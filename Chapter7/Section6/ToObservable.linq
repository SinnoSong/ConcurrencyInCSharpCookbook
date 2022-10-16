<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Reactive.Threading.Tasks</Namespace>
</Query>

var client = new HttpClient();
IObservable<HttpResponseMessage> response = client.GetAsync("http://www.example.com").ToObservable();