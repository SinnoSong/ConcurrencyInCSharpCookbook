<Query Kind="Program" />

void Main()
{
	CancelableMethod(CancellationToken.None);
}
public int CancelableMethod(CancellationToken cancellationToken)
{
	for (int i = 0; i != 100; ++i)
	{
		Thread.Sleep(1000);
		cancellationToken.ThrowIfCancellationRequested();
	}
	return 42;
}

