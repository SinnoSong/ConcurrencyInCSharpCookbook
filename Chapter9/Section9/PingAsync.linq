<Query Kind="Statements">
  <Namespace>System.Net.NetworkInformation</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task<PingReply> PingAsync(string hostNameOrAddress, CancellationToken cancellationToken)
{
	var ping = new Ping();
	using (cancellationToken.Register(() => ping.SendAsyncCancel()))
	{
		return await ping.SendPingAsync(hostNameOrAddress);
	}
}