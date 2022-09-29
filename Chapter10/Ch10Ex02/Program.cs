
ClassA myObject = new ClassA();
Console.WriteLine($"myObject.State = {myObject.State}");
ClassA.ClassB myOtherObject = new ClassA.ClassB();
myOtherObject.SetPrivateState(myObject, 999);
Console.WriteLine($"myObject.State = {myObject.State}");
Console.ReadKey();

public class ClassA
{
    private int state = -1;
    public int State => state;
    public class ClassB
    {
        public void SetPrivateState(ClassA target, int newState)
        {
            target.state = newState;
        }
    }
}
