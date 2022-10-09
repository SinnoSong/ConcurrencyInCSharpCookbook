<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static async Task<T> DelayResult<T>(T result, TimeSpan delay)
{
	await Task.Delay(delay);
	return result;
}