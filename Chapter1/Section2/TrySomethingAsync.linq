<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	await TrySomethingAsync();
}

async Task TrySomethingAsync()
{
	Task task = PossibleExceptionAsync();
	try
	{
		//await PossibleExceptionAsync();
		await task;
	}
	catch (NotSupportedException ex)
	{
		Console.WriteLine(ex);
		throw;
	}
}
async Task PossibleExceptionAsync()
{
	throw new NotSupportedException();
}