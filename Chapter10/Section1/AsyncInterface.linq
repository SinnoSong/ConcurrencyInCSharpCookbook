<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

interface IMyAsyncInterface
{
	Task<int> CountBytesAsync(string url);
}

class MyAsyncClass : IMyAsyncInterface
{
	public async Task<int> CountBytesAsync(string url)
	{
		var client = new HttpClient();
		var bytes = await client.GetByteArrayAsync(url);
		return bytes.Length;
	}

	public static async Task UseMyInterfaceAsync(IMyAsyncInterface service)
	{
		var result = await service.CountBytesAsync("http://www.google.com");
		Console.WriteLine(result);
	}
}