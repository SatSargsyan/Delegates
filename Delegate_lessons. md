### [Action Delegate](https://msdn.microsoft.com/en-us/library/system.action(v=vs.110).aspx)

Encapsulates a method that has no parameters and does not return a value.

```C#
public delegate void Action()
```

#### You can use this delegate to pass a method as a parameter without explicitly declaring a custom delegate. The encapsulated method must correspond to the method signature that is defined by this delegate. This means that the encapsulated method must have no parameters and no return value. (In C#, the method must return void. In Visual Basic, it must be defined by the Sub…End Sub construct. It can also be a method that returns a value that is ignored.) Typically, such a method is used to perform an operation.


To reference a method that has no parameters and returns a value, use the generic Func<TResult> delegate instead.
When you use the **Action delegate**, you do not have to explicitly define a delegate that encapsulates a parameterless procedure. For example, the following code explicitly declares a delegate named ShowValue and assigns a reference to the Name.DisplayToWindow instance method to its delegate instance.
```C#
using System;
using System.Windows.Forms;

public delegate void ShowValue();

public class Name
{
   private string instanceName;

   public Name(string name)
   {
      this.instanceName = name;
   }

   public void DisplayToConsole()
   {
      Console.WriteLine(this.instanceName);
   }

   public void DisplayToWindow()
   {
      MessageBox.Show(this.instanceName);
   }
}

public class testTestDelegate
{
   public static void Main()
   {
      Name testName = new Name("Koani");
      ShowValue showMethod = testName.DisplayToWindow;
      showMethod();
   }
}
```
The following example simplifies this code by instantiating the Action delegate instead of explicitly defining a new delegate and assigning a named method to it.
