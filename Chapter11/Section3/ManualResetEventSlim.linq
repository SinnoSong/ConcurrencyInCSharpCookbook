<Query Kind="Statements" />

class MyClass
{
	private readonly ManualResetEventSlim initialized = new ManualResetEventSlim();
	private int value;

	public void WaitForInitialization()
	{
		value = 13;
		initialized.Set();
	}
}