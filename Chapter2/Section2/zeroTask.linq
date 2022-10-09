<Query Kind="Expression">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

private static readonly Task<int> zeroTask = Task.FromResult(0);
static Task<int> GetValueAsync()
{
	return zeroTask;
}