<Query Kind="Program">
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

BufferBlock<int> asyncQueue = new BufferBlock<int>();
async Task Main()
{
	await Product();
	while (true)
	{
		int item;
		try
		{
			item = await asyncQueue.ReceiveAsync();
		}
		catch (InvalidOperationException ex)
		{
			break;
		}
		Console.WriteLine(item);
	}
}
async Task Product()
{
	await asyncQueue.SendAsync(7);
	await asyncQueue.SendAsync(13);
	asyncQueue.Complete();
}
