<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static void DoAction20Times(Action action)
{
	Action[] actions = Enumerable.Repeat(action, 20).ToArray();
	Parallel.Invoke(actions);
}

static void DoAction20TimesAndCancel(Action action, CancellationToken token)
{
	Action[] actions = Enumerable.Repeat(action, 20).ToArray();
	Parallel.Invoke(new ParallelOptions { CancellationToken = token }, actions);
}