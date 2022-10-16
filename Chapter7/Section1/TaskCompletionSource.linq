<Query Kind="Program">
  <Namespace>System.Net</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

public static Task<string> DownloadStringTaskAsync(this WebClient client, Uri address)
{
	var tcs = new TaskCompletionSource<string>();
	DownloadStringCompletedEventHandler handler = null;
	handler = (_, e) =>
	{
		client.DownloadStringCompleted -= handler;
		if (e.Cancelled)
		{
			tcs.TrySetCanceled();
		}
		else if (e.Error != null)
		{

			tcs.TrySetException(e.Error);
		}
		else
		{
			tcs.TrySetResult(e.Result);
		}
	};
	client.DownloadStringCompleted += handler;
	client.DownloadStringAsync(address);
	return tcs.Task;
}
