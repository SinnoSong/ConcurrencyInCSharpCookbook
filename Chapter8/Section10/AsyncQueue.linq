<Query Kind="Program">
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	Task.Run(async() => await Product());
	while (await queue.OutputAvailableAsync())
	{
		Console.WriteLine(await queue.ReceiveAsync());
	}
	while (true)
	{
		int item;
		try
		{
			item = await queue.ReceiveAsync();
		}
		catch (InvalidOperationException)
		{
			break;
		}
		Console.WriteLine(item);
	}
}

BufferBlock<int> queue = new BufferBlock<int>();
async Task Product()
{
	await queue.SendAsync(7);
	await queue.SendAsync(13);
	queue.Complete();
}