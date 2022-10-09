<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

static async Task<string> DownloadStringWithTimeout(string uri)
{
	using (var client = new HttpClient())
	{
		var downloadTask = client.GetStringAsync(uri);
		var timeoutTask = Task.Delay(3000);

		var completedTask = await Task.WhenAny(downloadTask, timeoutTask);
		if (completedTask == timeoutTask)
		{
			return null;
		}
		return await downloadTask;
	}
}