<Query Kind="Expression" />

public void CancelableMethodWithOverload(CancellationToken cancellationToken)
{
	// do something
}
public void CancelableMethWithOverload()
{
	CancelableMethodWithOverload(CancellationToken.None);
}
public void CancelableMethodWithDefault(CancellationToken cancellationToken = default(CancellationToken))
{
	// do something
}