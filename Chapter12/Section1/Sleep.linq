<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var task = Task.Run(() =>
{
	Thread.Sleep(TimeSpan.FromSeconds(2));
});
Task<int> task1 = Task.Run(async() =>
{
	await Task.Delay(TimeSpan.FromSeconds(2));
	return 13;
});