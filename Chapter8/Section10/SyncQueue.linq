<Query Kind="Program">
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Task.Run(() => Product());
	while (true)
	{
		int item;
		try
		{
			item = queue.Receive();
		}
		catch (InvalidOperationException)
		{
			break;
		}
		Console.WriteLine(item);
	}
}

BufferBlock<int> queue = new BufferBlock<int>();
void Product()
{
	queue.Post(7);
	queue.Post(13);
	queue.Complete();
}