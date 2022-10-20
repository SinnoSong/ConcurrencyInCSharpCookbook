<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task MyMethodAsync()
{
	int val = 10;
	await Task.Delay(TimeSpan.FromSeconds(1));
	val ++;
	await Task.Delay(TimeSpan.FromSeconds(1));
	val--;
	await Task.Delay(TimeSpan.FromSeconds(1));
	Console.WriteLine(val);
}
await MyMethodAsync();