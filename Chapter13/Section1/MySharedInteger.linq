<Query Kind="Expression" />

static int simpleValue;
static readonly Lazy<int> MySharedInteger = new Lazy<int>(() => simpleValue++);
void UseSharedInteger()
{
	int sharedValue = MySharedInteger.Value;
}