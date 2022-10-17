<Query Kind="Program">
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Task.Run(() => Product());
	Task.Run(async() => await ProductAsync());
	ActionBlock<int> queue = new ActionBlock<int>(item => Console.WriteLine(item));
}

BufferBlock<int> queue = new BufferBlock<int>();
void Product()
{
	queue.Post(7);
	queue.Post(13);
	queue.Complete();
}
async Task ProductAsync()
{
	await queue.SendAsync(7);
	await queue.SendAsync(13);
}