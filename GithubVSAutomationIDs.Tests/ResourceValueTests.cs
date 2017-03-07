using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Globalization;
using System.Resources;

namespace GitHub.VisualStudio.TestAutomation
{
    [TestClass]
    public class ResourceValueTest
    {
        [TestMethod]
        public void ValueAndNameAreTheSame()
        {
            ResourceSet autoIDResourceSet = AutomationIDs.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in autoIDResourceSet)
            {
                var key = entry.Key.ToString();
                var value = entry.Value.ToString();

                Assert.AreEqual(value, key);
            }
        }
    }
}