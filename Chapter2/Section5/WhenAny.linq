<Query Kind="Expression">
  <Namespace>System.Net.Http</Namespace>
</Query>

private static async Task<int> FirstRespondingUrlAsync(string urlA, string urlB)
{
	var httpClient = new HttpClient();
	Task<byte[]> downloadTaskA = httpClient.GetByteArrayAsync(urlA);
	Task<byte[]> downloadTaskB = httpClient.GetByteArrayAsync(urlB);
	Task<byte[]> completedTask = await Task.WhenAny(downloadTaskA, downloadTaskB);

	byte[] data = await completedTask;
	return data.Length;
}