<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task IssueTimeoutAsync()
{
	var cts = new CancellationTokenSource();
	var token = cts.Token;
	cts.CancelAfter(TimeSpan.FromSeconds(5));
	await Task.Delay(TimeSpan.FromSeconds(10), token);
}