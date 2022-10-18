<Query Kind="Statements">
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task<HttpResponseMessage> GetWithTimeoutAsync(string url, CancellationToken cancellationToken)
{
	var client = new HttpClient();
	using (var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
	{
		cts.CancelAfter(TimeSpan.FromSeconds(2));
		var combinedToken = cts.Token;
		return await client.GetAsync(url, combinedToken);
	}
}