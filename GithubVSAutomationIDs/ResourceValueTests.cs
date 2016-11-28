using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Globalization;
using System.Resources;

namespace GithubVSAutomationIDs
{
    [TestClass]
    public class ResourceValueTest
    {
        [TestMethod]
        public void ValueAndNameAreTheSame()
        {
            ResourceSet autoIDResourceSet = AutomationIDs.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, false, true);
            foreach (DictionaryEntry entry in autoIDResourceSet)
            {
                var key = entry.Key.ToString();
                var value = entry.Value.ToString();

                Assert.AreEqual(value, key);
            }
        }
    }
}