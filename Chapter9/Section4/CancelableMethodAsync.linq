<Query Kind="Expression">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

public async Task<int> CancelableMethodAsync(CancellationToken cancellationToken)
{
	await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken);
	return 42;
}