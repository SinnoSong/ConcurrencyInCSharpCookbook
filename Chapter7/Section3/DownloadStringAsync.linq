<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

public interface IMyAsyncHttpService
{
	void DownloadString(Uri address, Action<string, Exception> callback);
}
public static Task<string> DownloadStringAsync(this IMyAsyncHttpService httpService, Uri address)
{
	var tcs = new TaskCompletionSource<string>();

	httpService.DownloadString(address, (result, exception) =>
	{
		if (exception != null)
		{
			tcs.TrySetException(exception);
		}
		else
		{
			tcs.TrySetResult(result);
		}
	});
	return tcs.Task;
}
