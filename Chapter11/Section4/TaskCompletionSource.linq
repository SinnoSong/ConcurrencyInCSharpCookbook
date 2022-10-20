<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

class MyClass
{
	private readonly TaskCompletionSource<object> initialized = new TaskCompletionSource<object>();

	private int value1;
	private int value2;

	public async Task<int> WaitForInitializationAsync()
	{
		await initialized.Task;
		return value1 + value2;
	}

	public void Initialize()
	{
		value1 = 13;
		value2 = 17;
		initialized.TrySetResult(null);
	}
}