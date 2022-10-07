<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Deadlock();
}
async Task WaitAsync()
{
	await Task.Delay(TimeSpan.FromSeconds(1));
}
void Deadlock()
{
	Task task = WaitAsync();
	task.Wait();
}