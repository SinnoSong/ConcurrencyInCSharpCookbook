<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static async Task<int> DelayAndReturnAsync(int val)
{
	await Task.Delay(TimeSpan.FromSeconds(val));
	return val;
}
static async Task ProcessTasksAsync()
{
	Task<int> taskA = DelayAndReturnAsync(2);
	Task<int> taskB = DelayAndReturnAsync(3);
	Task<int> taskC = DelayAndReturnAsync(1);
	var tasks = new[] { taskA, taskB, taskC };

	var processingTasks = tasks.Select(async t =>
	{
		var result = await t;
		Console.WriteLine(result);
	});
	await Task.WhenAll(processingTasks);
}
ProcessTasksAsync();