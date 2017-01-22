using System.Text;

namespace SimpleInjector.Modules.TestApp
{
    public class MyModule : Module
    {
        public override void Load(Container container)
        {
            container.Register(() => new StringBuilder());
        }
    }
}
