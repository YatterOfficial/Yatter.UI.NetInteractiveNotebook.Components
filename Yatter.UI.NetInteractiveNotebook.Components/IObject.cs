using System;
namespace Yatter.UI.NetInteractiveNotebook.Components
{
    public interface IObject : IPrinter
    {
        public void AddPrinter(IPrinter printer);
    }
}
