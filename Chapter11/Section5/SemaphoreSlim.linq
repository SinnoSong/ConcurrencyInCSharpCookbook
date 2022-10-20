<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

async Task<string[]> DownloadUrlsAsync(IEnumerable<string> urls)
{
	var httpClient = new HttpClient();
	var semaphore = new SemaphoreSlim(10);
	var tasks = urls.Select(async url =>
	{
		await semaphore.WaitAsync();
		try
		{
			return await httpClient.GetStringAsync(url);
		}
		finally
		{
			semaphore.Release();
		}
	}).ToArray();
	return await Task.WhenAll(tasks);
}