using System.Linq;
using NUnit.Framework;

namespace Wikiled.Text.Inquirer.Tests.Logic
{
    [TestFixture]
    public class ConjunctionDataTests
    {
        [Test]
        public void IsClausal()
        {
            var definitions = Global.Manager.GetDefinitions("because");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Conjunction.HasData);
            var instance = definition.Description.Syntactic.Conjunction;
            Assert.IsTrue(instance.IsConjunction);
            Assert.IsTrue(instance.IsClausal);
            Assert.IsFalse(instance.IsSentential);
        }

        [Test]
        public void IsSentential()
        {
            var definitions = Global.Manager.GetDefinitions("and");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Conjunction.HasData);
            var instance = definition.Description.Syntactic.Conjunction;
            Assert.IsTrue(instance.IsConjunction);
            Assert.IsFalse(instance.IsClausal);
            Assert.IsTrue(instance.IsSentential);
        }
    }
}
