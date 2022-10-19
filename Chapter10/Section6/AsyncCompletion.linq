<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

interface IAsyncCompletion
{
	void Complete();

	Task Completion { get; }
}
class MyClass : IAsyncCompletion
{
	private readonly TaskCompletionSource<object> completion = new TaskCompletionSource<object>();
	private Task completing;
	public Task Completion { get { return completion.Task; } }

	public void Complete()
	{
		if (completing != null)
		{
			return;
		}
		completing = CompleteAsync();
	}

	private async Task CompleteAsync()
	{

		try
		{
			// do something
		}
		catch (Exception ex)
		{
			completion.TrySetException(ex);
		}
		finally
		{
			completion.TrySetResult(null);
		}
	}
}