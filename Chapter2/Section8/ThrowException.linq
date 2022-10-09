<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static async Task ThrowExceptionAsync()
{
	await Task.Delay(TimeSpan.FromSeconds(1));
	throw new InvalidOperationException("Test");
}
static async Task TestAsync()
{
	Task task = ThrowExceptionAsync();
	try
	{
		await task;
	}
	catch (Exception ex)
	{
		throw;
	}
}