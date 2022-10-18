<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	Task.Run(async() => await CancelableMethodAysnc());
	await Task.Delay(3000);
	IssueCancelRequest();
}
async void IssueCancelRequest()
{
	var cts = new CancellationTokenSource();
	var task = CancelableMethodAysnc(cts.Token);
	cts.Cancel();
	try
	{
		await task;
	}
	catch (OperationCanceledException)
	{
		// operation was canceled before finish
	}
	catch (Exception)
	{
		//operation error before cancel
		throw;
	}
}
static async Task CancelableMethodAysnc(CancellationToken token = default(CancellationToken))
{
	await Task.Delay(10000);
}

