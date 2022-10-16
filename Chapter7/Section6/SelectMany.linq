<Query Kind="Statements">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Reactive.Threading.Tasks</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

IObservable<string> urls = Enumerable.Repeat("http://wjlk", 2).ToObservable();
var client = new HttpClient();
IObservable<HttpResponseMessage> response =
urls.SelectMany((url, token) => client.GetAsync(url, token));