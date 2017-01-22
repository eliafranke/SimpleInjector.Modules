using System;

namespace SimpleInjector.Modules.TestApp.Library
{
    internal sealed class MyInternalClass : IMyClass
    {
        void IMyClass.MyMethod(Guid parameterA, int parameterB)
        {
            Console.WriteLine("A: {0}, B: {1}", parameterA, parameterB);
        }
    }
}