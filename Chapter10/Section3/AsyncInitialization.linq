<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

public interface IAsyncInitialization
{
	public Task Initialization { get; }
}
interface IMyFundamentalType
{
}
class MyFundamentalType : IAsyncInitialization, IMyFundamentalType
{
	public MyFundamentalType()
	{
		Initialization = InitializeAsync();
	}
	public Task Initialization { get; private set; }

	private async Task InitializeAsync()
	{
		await Task.Delay(TimeSpan.FromSeconds(1));
	}
}
class MyComposedType : IAsyncInitialization
{
	private readonly IMyFundamentalType fundamental;
	public Task Initialization { get; private set; }

	public MyComposedType(IMyFundamentalType fundamental)
	{
		this.fundamental = fundamental;
		Initialization = InitializeAsync();
	}

	private async Task InitializeAsync()
	{
		var fundamentalAsyncInit = fundamental as IAsyncInitialization;
		if (fundamentalAsyncInit != null)
		{
			await fundamentalAsyncInit.Initialization;
		}
	}
}