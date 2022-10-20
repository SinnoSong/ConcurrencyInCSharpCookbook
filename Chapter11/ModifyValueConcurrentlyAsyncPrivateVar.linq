<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	Console.WriteLine(await ModifyValueConcurrentlyAsync());
}
private int value;
async Task ModifyValueAsync()
{
	await Task.Delay(TimeSpan.FromSeconds(1));
	value = value + 1;
}
async Task<int> ModifyValueConcurrentlyAsync()
{
	// start 3 concurrent modify operations
	var task1 = ModifyValueAsync();
	var task2 = ModifyValueAsync();
	var task3 = ModifyValueAsync();

	await Task.WhenAll(task1, task2, task3);
	return value;
}