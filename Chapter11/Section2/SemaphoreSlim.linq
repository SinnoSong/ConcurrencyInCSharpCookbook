<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

class MyClass
{
	// protect value
	private readonly SemaphoreSlim mutex = new SemaphoreSlim(1);
	private int value;

	public async Task DelayAndIncrementAsync()
	{
		await mutex.WaitAsync();
		try
		{
			var oldValue = value;
			await Task.Delay(TimeSpan.FromSeconds(oldValue));
			value = oldValue + 1;
		}
		finally
		{
			mutex.Release();
		}
	}
}