using System;
namespace Yatter.UI.NetInteractiveNotebook.Components
{
    public abstract class ObjectBase
    {
        [Newtonsoft.Json.JsonIgnore] // We don't want this serialized for transmission over the internet, or deserialized from it.
        public IPrinter Printer { get; set; }

        public void AddPrinter(IPrinter printer)
        {
            Printer = printer;
        }

        public abstract void PrintObject();
    }
}
