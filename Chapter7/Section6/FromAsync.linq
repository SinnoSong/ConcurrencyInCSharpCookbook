<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Reactive.Threading.Tasks</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

var client = new HttpClient();
IObservable<HttpResponseMessage> response =
Observable.FromAsync(token => client.GetAsync("http://www.example.com", token));