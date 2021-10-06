using System;
namespace Yatter.UI.NetInteractiveNotebook.Components
{
    public static class EasyPrinter
    {
        public static void Print(IObject obj)
        {
            obj.PrintObject();
        }

        public static void Print<TObject, TPrinter>(string json)
            where TObject : ObjectBase, new()
            where TPrinter : PrinterBase, new()
        {
            TObject tObject = default(TObject);
            tObject = Newtonsoft.Json.JsonConvert.DeserializeObject<TObject>(json);

            TPrinter tPrinter = default(TPrinter);
            tPrinter = new TPrinter();
            tPrinter.AddObject(tObject);

            tObject.AddPrinter((IPrinter)tPrinter);

            tPrinter.PrintObject();
        }
    }
}
