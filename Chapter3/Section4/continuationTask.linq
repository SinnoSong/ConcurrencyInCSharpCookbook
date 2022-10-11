<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task task = Task.Factory.StartNew(
	() => Thread.Sleep(TimeSpan.FromSeconds(2)),
	CancellationToken.None,
	TaskCreationOptions.None,
	TaskScheduler.Default
);
Task continuation = task.ContinueWith(
	t => Console.WriteLine("Task is done"),
	CancellationToken.None,
	TaskContinuationOptions.None,
	TaskScheduler.Default
);