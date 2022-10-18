<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task IssueTimeoutAsync()
{
	var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
	var token = cts.Token;
	await Task.Delay(TimeSpan.FromSeconds(10), token);
}