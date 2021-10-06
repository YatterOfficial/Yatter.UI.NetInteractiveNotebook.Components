using System;
namespace Yatter.UI.NetInteractiveNotebook.Components
{
    interface IObject : IPrinter
    {
        void AddPrinter(IPrinter printer);
    }
}
