<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	await DoSomethingAsync();
}

// You can define other methods, fields, classes and namespaces here
async Task DoSomethingAsync()
{
	int val = 13;
	await Task.Delay(TimeSpan.FromSeconds(1));
	val *= 2;
	await Task.Delay(TimeSpan.FromSeconds(1));
	//Trace.WriteLine(val);
	Console.WriteLine(val);
}