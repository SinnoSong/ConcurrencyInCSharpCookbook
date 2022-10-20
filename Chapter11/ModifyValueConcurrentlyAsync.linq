<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
 	Console.WriteLine(await ModifyValueConcurrentlyAsync());
}

class ShardData
{
	public int Value { get; set; }
}
async Task ModifyValueAsync(ShardData data)
{
	await Task.Delay(TimeSpan.FromSeconds(1));
	data.Value = data.Value + 1;
}
async Task<int> ModifyValueConcurrentlyAsync()
{
	var data = new ShardData();
	// start 3 concurrent modify operations
	var task1 = ModifyValueAsync(data);
	var task2 = ModifyValueAsync(data);
	var task3 = ModifyValueAsync(data);

	await Task.WhenAll(task1, task2, task3);
	return data.Value;
}