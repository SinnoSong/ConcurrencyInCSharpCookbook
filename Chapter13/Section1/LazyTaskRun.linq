<Query Kind="Expression">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static int simpleValue;
static readonly Lazy<Task<int>> MySharedAsyncInteger = new Lazy<Task<int>>(() => Task.Run(async() =>
  {
	  await Task.Delay(TimeSpan.FromSeconds(2)).ConfigureAwait(false);
	  return simpleValue++;
  }));
async Task GetSharedIntegerAsync()
{
	int sharedValue = await MySharedAsyncInteger.Value;
}