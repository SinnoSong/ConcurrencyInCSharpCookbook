<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

class MyClass : IDisposable
{
	private readonly CancellationTokenSource disposeCts = new CancellationTokenSource();

	public async Task<int> CalculateValueAsync()
	{
		await Task.Delay(TimeSpan.FromSeconds(2), disposeCts.Token);
		return 13;
	}

	public async Task<int> CalculateValueAsync(CancellationToken cancellationToken)
	{
		using (var combinedCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, disposeCts.Token))
		{
			await Task.Delay(TimeSpan.FromSeconds(2), disposeCts.Token);
			return 13;
		}
	}

	public void Dispose()
	{
		disposeCts.Cancel();
	}
}