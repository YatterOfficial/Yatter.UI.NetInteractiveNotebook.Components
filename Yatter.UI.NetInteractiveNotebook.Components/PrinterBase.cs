using System;
namespace Yatter.UI.NetInteractiveNotebook.Components
{
    public abstract class PrinterBase : IPrinter
    {
        public ObjectBase Obj { get; set; }

        public abstract void PrintObject();

        public void AddObject(ObjectBase obj)
        {
            Obj = obj;
        }
    }
}
