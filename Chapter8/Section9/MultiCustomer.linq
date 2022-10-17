<Query Kind="Program">
  <NuGetReference>Nito.AsyncEx.Coordination</NuGetReference>
  <NuGetReference>Nito.AsyncEx.Tasks</NuGetReference>
  <Namespace>Nito.AsyncEx</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	Task.Run(async() => await Product());
	while (true)
	{
		try
		{
			Console.WriteLine(await asyncStack.TakeAsync());
		}
		catch (InvalidOperationException ex)
		{
			break;
		}

	}
}

AsyncCollection<int> asyncStack = new AsyncCollection<int>(new ConcurrentStack<int>(), maxCount: 1);
AsyncCollection<int> asyncBag = new AsyncCollection<int>(new ConcurrentBag<int>());

async Task Product()
{
	await asyncStack.AddAsync(7);
	await asyncStack.AddAsync(13);
	asyncStack.CompleteAdding();
}