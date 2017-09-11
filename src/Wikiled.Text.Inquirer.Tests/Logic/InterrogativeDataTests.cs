using System.Linq;
using NUnit.Framework;

namespace Wikiled.Text.Inquirer.Tests.Logic
{
    [TestFixture]
    public class InterrogativeDataTests
    {
        [Test]
        public void IsClausal()
        {
            var definitions = Global.Manager.GetDefinitions("why");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Interrogative.HasData);
            var instance = definition.Description.Syntactic.Interrogative;
            Assert.IsTrue(instance.IsInterrogatives);
        }
    }
}
