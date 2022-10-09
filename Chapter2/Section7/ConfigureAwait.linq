<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async Task ResumeOnContextAsync()
{
	await Task.Delay(TimeSpan.FromSeconds(1));
}
async Task ResumeWithoutContextAsync()
{
	await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
}