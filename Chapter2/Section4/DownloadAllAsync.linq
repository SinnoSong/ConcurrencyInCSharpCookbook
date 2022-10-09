<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

static async Task<string> DownloadAllAsync(IEnumerable<string> urls)
{
	var httpClient = new HttpClient();
	var downloads = urls.Select(url => httpClient.GetStringAsync(url));
	Task<string>[] downloadTasks = downloads.ToArray();
	string[] htmlPages = await Task.WhenAll(downloadTasks);
	return string.Concat(htmlPages);
}