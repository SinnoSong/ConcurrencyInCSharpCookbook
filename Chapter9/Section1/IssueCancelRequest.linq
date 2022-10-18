<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task Main()
{
	Task.Run(async() => await CancelableMethodAysnc());
	await Task.Delay(3000);
	IssueCancelRequest();
}
void IssueCancelRequest()
{
	var cts = new CancellationTokenSource();
	var task = CancelableMethodAysnc(cts.Token);
	cts.Cancel();
}
static async Task CancelableMethodAysnc(CancellationToken token = default(CancellationToken))
{
	await Task.Delay(10000);
}

