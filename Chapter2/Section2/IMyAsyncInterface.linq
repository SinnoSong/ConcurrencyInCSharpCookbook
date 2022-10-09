<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var obj = new MySynchronousImplementation();
	Console.WriteLine(obj.GetValueAsync());
}

interface IMyAsyncInterface
{
	Task<int> GetValueAsync();
}
class MySynchronousImplementation : IMyAsyncInterface
{
	public Task<int> GetValueAsync()
	{
		return Task.FromResult(13);
	}
}
