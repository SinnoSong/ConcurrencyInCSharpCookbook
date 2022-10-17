<Query Kind="Program">
  <Namespace>System.Collections.Concurrent</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Task.Run(() => Product());
	foreach (var item in blockingQueue.GetConsumingEnumerable())
	{
		Console.WriteLine(item);
	}
}
private readonly BlockingCollection<int> blockingQueue = new BlockingCollection<int>(boundedCapacity: 1);

void Product()
{
	blockingQueue.Add(7);
	blockingQueue.Add(13);
	blockingQueue.CompleteAdding();
}