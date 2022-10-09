<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

static async Task<string> DownloadStringWithRetries(string uri)
{
	using (var client = new HttpClient())
	{
		var nextDelay = TimeSpan.FromSeconds(1);
		for (int i = 0; i != 3; ++i)
		{
			try
			{
				return await client.GetStringAsync(uri);
			}
			catch (Exception ex)
			{
			}

			await Task.Delay(nextDelay);
			nextDelay = nextDelay + nextDelay;
		}
		// 最后重试一次
		return await client.GetStringAsync(uri);
	}
}