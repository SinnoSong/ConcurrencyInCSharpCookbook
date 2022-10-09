<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static async Task<int> DelayAndReturnAsync(int val)
{
	await Task.Delay(TimeSpan.FromSeconds(val));
	return val;
}
static async Task AwaitAndProcessAsync(Task<int> task)
{
	var result = await task;
	Console.WriteLine(result);
}
static async Task ProcessTasksAsync()
{
	Task<int> taskA = DelayAndReturnAsync(2);
	Task<int> taskB = DelayAndReturnAsync(3);
	Task<int> taskC = DelayAndReturnAsync(1);
	var tasks = new[] { taskA, taskB, taskC };

	var processingTasks = (from t in tasks select AwaitAndProcessAsync(t)).ToArray();
	await Task.WhenAll(processingTasks);
}
ProcessTasksAsync();