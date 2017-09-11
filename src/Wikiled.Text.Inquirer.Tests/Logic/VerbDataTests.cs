using System.Linq;
using NUnit.Framework;

namespace Wikiled.Text.Inquirer.Tests.Logic
{
    [TestFixture]
    public class VerbDataTests
    {
        [Test]
        public void IsBeingVerb()
        {
            var definitions = Global.Manager.GetDefinitions("being");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Verb.IsVerb);
            var instance = definition.Description.Syntactic.Verb;
            Assert.IsTrue(instance.IsVerb);
            Assert.IsFalse(instance.IsBecomingVerbs);
            Assert.IsTrue(instance.IsBeingVerb);
            Assert.IsFalse(instance.IsDoVerb);
            Assert.IsFalse(instance.IsGoVerb);
            Assert.IsFalse(instance.IsHave);
            Assert.IsFalse(instance.IsLinkingVerb);
            Assert.IsFalse(instance.IsModal);
            Assert.IsFalse(instance.IsNegative);
            Assert.IsTrue(instance.IsSuperverb);
            Assert.IsFalse(instance.IsTo);
        }

        [Test]
        public void IsLinkingVerb()
        {
            var definitions = Global.Manager.GetDefinitions("look");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Verb.IsVerb);
            var instance = definition.Description.Syntactic.Verb;
            Assert.IsTrue(instance.IsVerb);
            Assert.IsFalse(instance.IsBecomingVerbs);
            Assert.IsFalse(instance.IsBeingVerb);
            Assert.IsFalse(instance.IsDoVerb);
            Assert.IsFalse(instance.IsGoVerb);
            Assert.IsFalse(instance.IsHave);
            Assert.IsTrue(instance.IsLinkingVerb);
            Assert.IsFalse(instance.IsModal);
            Assert.IsFalse(instance.IsNegative);
            Assert.IsTrue(instance.IsSuperverb);
            Assert.IsFalse(instance.IsTo);
        }

        [Test]
        public void IsBecomingVerbs()
        {
            var definitions = Global.Manager.GetDefinitions("get");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Verb.IsVerb);
            var instance = definition.Description.Syntactic.Verb;
            Assert.IsTrue(instance.IsVerb);
            Assert.IsTrue(instance.IsBecomingVerbs);
            Assert.IsFalse(instance.IsBeingVerb);
            Assert.IsFalse(instance.IsDoVerb);
            Assert.IsFalse(instance.IsGoVerb);
            Assert.IsFalse(instance.IsHave);
            Assert.IsFalse(instance.IsLinkingVerb);
            Assert.IsFalse(instance.IsModal);
            Assert.IsFalse(instance.IsNegative);
            Assert.IsTrue(instance.IsSuperverb);
            Assert.IsFalse(instance.IsTo);
        }

        [Test]
        public void IsHave()
        {
            var definitions = Global.Manager.GetDefinitions("had");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Verb.IsVerb);
            var instance = definition.Description.Syntactic.Verb;
            Assert.IsTrue(instance.IsVerb);
            Assert.IsFalse(instance.IsBecomingVerbs);
            Assert.IsFalse(instance.IsBeingVerb);
            Assert.IsFalse(instance.IsDoVerb);
            Assert.IsFalse(instance.IsGoVerb);
            Assert.IsTrue(instance.IsHave);
            Assert.IsFalse(instance.IsLinkingVerb);
            Assert.IsFalse(instance.IsModal);
            Assert.IsFalse(instance.IsNegative);
            Assert.IsTrue(instance.IsSuperverb);
            Assert.IsFalse(instance.IsTo);
        }

        [Test]
        public void IsModal()
        {
            var definitions = Global.Manager.GetDefinitions("shall");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Verb.IsVerb);
            var instance = definition.Description.Syntactic.Verb;
            Assert.IsTrue(instance.IsVerb);
            Assert.IsFalse(instance.IsBecomingVerbs);
            Assert.IsFalse(instance.IsBeingVerb);
            Assert.IsFalse(instance.IsDoVerb);
            Assert.IsFalse(instance.IsGoVerb);
            Assert.IsFalse(instance.IsHave);
            Assert.IsFalse(instance.IsLinkingVerb);
            Assert.IsTrue(instance.IsModal);
            Assert.IsFalse(instance.IsNegative);
            Assert.IsTrue(instance.IsSuperverb);
            Assert.IsFalse(instance.IsTo);
        }

        [Test]
        public void IsGoVerb()
        {
            var definitions = Global.Manager.GetDefinitions("gone");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Verb.IsVerb);
            var instance = definition.Description.Syntactic.Verb;
            Assert.IsTrue(instance.IsVerb);
            Assert.IsFalse(instance.IsBecomingVerbs);
            Assert.IsFalse(instance.IsBeingVerb);
            Assert.IsFalse(instance.IsDoVerb);
            Assert.IsTrue(instance.IsGoVerb);
            Assert.IsFalse(instance.IsHave);
            Assert.IsFalse(instance.IsLinkingVerb);
            Assert.IsFalse(instance.IsModal);
            Assert.IsFalse(instance.IsNegative);
            Assert.IsTrue(instance.IsSuperverb);
            Assert.IsFalse(instance.IsTo);
        }

        [Test]
        public void IsDoVerb()
        {
            var definitions = Global.Manager.GetDefinitions("did");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Verb.IsVerb);
            var instance = definition.Description.Syntactic.Verb;
            Assert.IsTrue(instance.IsVerb);
            Assert.IsFalse(instance.IsBecomingVerbs);
            Assert.IsTrue(instance.IsDoVerb);
            Assert.IsFalse(instance.IsGoVerb);
            Assert.IsFalse(instance.IsHave);
            Assert.IsFalse(instance.IsLinkingVerb);
            Assert.IsFalse(instance.IsModal);
            Assert.IsFalse(instance.IsNegative);
            Assert.IsTrue(instance.IsSuperverb);
            Assert.IsFalse(instance.IsTo);
        }

        [Test]
        public void IsTo()
        {
            var definitions = Global.Manager.GetDefinitions("to");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Verb.IsVerb);
            var instance = definition.Description.Syntactic.Verb;
            Assert.IsTrue(instance.IsVerb);
            Assert.IsFalse(instance.IsBecomingVerbs);
            Assert.IsFalse(instance.IsDoVerb);
            Assert.IsFalse(instance.IsGoVerb);
            Assert.IsFalse(instance.IsHave);
            Assert.IsFalse(instance.IsLinkingVerb);
            Assert.IsFalse(instance.IsModal);
            Assert.IsFalse(instance.IsNegative);
            Assert.IsTrue(instance.IsSuperverb);
            Assert.IsTrue(instance.IsTo);
        }

        [Test]
        public void IsSuperverb()
        {
            var definitions = Global.Manager.GetDefinitions("take");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Verb.IsSuperverb);
            var instance = definition.Description.Syntactic.Verb;
            Assert.IsFalse(instance.IsBecomingVerbs);
            Assert.IsFalse(instance.IsDoVerb);
            Assert.IsFalse(instance.IsGoVerb);
            Assert.IsFalse(instance.IsHave);
            Assert.IsFalse(instance.IsLinkingVerb);
            Assert.IsFalse(instance.IsModal);
            Assert.IsFalse(instance.IsNegative);
            Assert.IsTrue(instance.IsSuperverb);
            Assert.IsFalse(instance.IsTo);
        }
    }
}
