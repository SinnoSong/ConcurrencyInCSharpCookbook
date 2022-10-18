<Query Kind="Program" />

void Main()
{
	CancelableMethod(CancellationToken.None);
}
public int CancelableMethod(CancellationToken cancellationToken)
{
	for (int i = 0; i != 100000; ++i)
	{
		Thread.Sleep(1);
		if (i % 1000 == 0)
		{
			cancellationToken.ThrowIfCancellationRequested();
		}
	}
	return 42;
}

