<Query Kind="Program">
  <Namespace>System.Collections.Concurrent</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Task.Run(() => Product());
	foreach (var item in blockingStack.GetConsumingEnumerable())
	{
		Console.WriteLine(item);
	}

}
BlockingCollection<int> blockingBag = new BlockingCollection<int>(new ConcurrentBag<int>());
BlockingCollection<int> blockingStack = new BlockingCollection<int>(new ConcurrentStack<int>());
void Product()
{
	blockingStack.Add(7);
	blockingStack.Add(13);
	blockingStack.CompleteAdding();
}