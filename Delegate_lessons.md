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

```C#
using System;
using System.Windows.Forms;

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
      Action showMethod = testName.DisplayToWindow;
      showMethod();
   }
}
```

### [Action`<T>` Delegate](https://msdn.microsoft.com/en-us/library/018hxwa8(v=vs.110).aspx)


Encapsulates a method that has a single parameter and does not return a value.

```c#
public delegate void Action<in T>(
	T obj
)
```

#### Parameters
obj
Type: T
The parameter of the method that this delegate encapsulates.
Type Parameters
in T
The type of the parameter of the method that this delegate encapsulates.


When you use the Action `<T>` delegate, you do not have to explicitly define a delegate that encapsulates a method with a single parameter. For example, the following code explicitly declares a delegate named DisplayMessage and assigns a reference to either the WriteLine method or the ShowWindowsMessage method to its delegate instance.
```C#
using System;
using System.Windows.Forms;

delegate void DisplayMessage(string message);

public class TestCustomDelegate
{
   public static void Main()
   {
      DisplayMessage messageTarget; 

      if (Environment.GetCommandLineArgs().Length > 1)
         messageTarget = ShowWindowsMessage;
      else
         messageTarget = Console.WriteLine;

      messageTarget("Hello, World!");   
   }      

   private static void ShowWindowsMessage(string message)
   {
      MessageBox.Show(message);      
   }
}
```

### In [Reference Source ](http://referencesource.microsoft.com/#mscorlib/system/action.cs,486d58da4553e12d) it has next
```C#
public delegate void Action<in T>(T obj); 
 
    // Action/Func delegates first shipped with .NET Framework 3.5 in System.Core.dll as part of LINQ
    // These were type forwarded to mscorlib.dll in .NET Framework 4.0 and in Silverlight 5.0
 
#if FEATURE_CORECLR
    [TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
#else
    [TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
#endif
    public delegate void Action();
 
#if FEATURE_CORECLR
    [TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
#else
    [TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
#endif
    public delegate void Action<in T1,in T2>(T1 arg1, T2 arg2);
 
#if FEATURE_CORECLR
    [TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
#else
    [TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=Neutral, PublicKeyToken=b77a5c561934e089")]
#endif
    public delegate void Action<in T1,in T2,in T3>(T1 arg1, T2 arg2, T3 arg3);
```

