<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static async Task ThrowNotImplementedExceptionAsync()
{
	throw new NotImplementedException();
}
static async Task ThrowInvalidOperationExceptionAsync()
{
	throw new InvalidOperationException();
}
static async Task ObserveOneExceptionAsync()
{
	var task1 = ThrowNotImplementedExceptionAsync();
	var task2 = ThrowInvalidOperationExceptionAsync();
	try
	{
		await Task.WhenAll(task1, task2);
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex);
	}
}

static async Task ObserveAllExceptionsAsync()
{
	var task1 = ThrowNotImplementedExceptionAsync();
	var task2 = ThrowInvalidOperationExceptionAsync();
	Task allTasks = Task.WhenAll(task1, task2);

	try
	{
		await allTasks;
	}
	catch
	{
		AggregateException allExceptions = allTasks.Exception;
		Console.WriteLine(allExceptions);
	}
}