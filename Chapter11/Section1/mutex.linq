<Query Kind="Statements" />

class MyClass
{
	private readonly object mutex = new object();
	private int value;
	public void Increment()
	{
		lock (mutex)
		{
			value = value + 1;
		}
	}
}