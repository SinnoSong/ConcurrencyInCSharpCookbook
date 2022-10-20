<Query Kind="Program">
  <NuGetReference>System.Reactive</NuGetReference>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Reactive.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var invokeServerObservable = Observable.Defer(() => GetValueAsync().ToObservable());
	invokeServerObservable.Subscribe(_ => { });
	invokeServerObservable.Subscribe(_ => { });
}
static async Task<int> GetValueAsync()
{
	Console.WriteLine("Calling server...");
	await Task.Delay(TimeSpan.FromSeconds(2));
	Console.WriteLine("Returning result...");
	return 13;
}

