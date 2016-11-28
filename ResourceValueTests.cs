using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
public class ResourceValueTest
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
    public void ValueAndNameAreTheSame()
    {
        ResourceSet resourceSet = MyResourceClass.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
        foreach (DictionaryEntry entry in resourceSet)
        {
            string resourceKey = entry.Key.ToString();
            object resource = entry.Value;
        }
    }
}
