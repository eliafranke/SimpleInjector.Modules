# SimpleInjector.Modules
Extends SimpleInjector with capability to Register Modules to the container which comes very handy if you follow SOLID principles and don't want to expose your internal class implementations.

Inherit your module from IModule and implement the Load method.
Simply call on your container .RegisterModule&lt;TModule>() - done!

### Instructions
1. Install nuget package via Nuget Package Manager or command line:

    ```
    PM> Install-Package SimpleInjector.Modules
    ```

2. Create a **module** class, e.g.:

    ```
    public sealed class MyProjectModule.cs : IModule
    {
    	void IModule.Load(Container container)
        {
            // Insert here your container registrations
        }
    }
    ```

3. Register the module with you **container**

	```
    var container = new Container();
    container.RegisterModule<MyProjectModule>();
    ```

4. Use your container as you are use to, either via constructor injection or ```container.GetInstance<MyClass>()```


### Example
Here a whole example: (you have to install the nuget package `SimpleInjector.Modules` first)

```
/* Program.cs: */

using System;
using SimpleInjector.Modules.TestApp.Library;
namespace SimpleInjector.Modules.TestApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.RegisterModule<TestAppModule>();

            var myClass = container.GetInstance<IMyClass>();
            myClass.MyMethod(Guid.NewGuid(), new Random().Next());

            Console.ReadKey();
        }
    }
}

/* (Separate project) */
using System;
namespace SimpleInjector.Modules.TestApp.Library
{
	/* TestAppModule.cs: */
    public sealed class TestAppModule : IModule
    {
        void IModule.Load(Container container)
        {
            container.Register<IMyClass, MyInternalClass>();
        }
    }

	/* IMyClass.cs */
    public interface IMyClass
    {
        void MyMethod(Guid parameterA, int parameterB);
    }
    
    /* MyInternalClass.cs */
    internal sealed class MyInternalClass : IMyClass
    {
        void IMyClass.MyMethod(Guid parameterA, int parameterB)
        {
            Console.WriteLine("A: {0}, B: {1}", parameterA, parameterB);
        }
    }
}
```