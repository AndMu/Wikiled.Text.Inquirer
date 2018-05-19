using System.Linq;
using NUnit.Framework;

namespace Wikiled.Text.Inquirer.Tests.Logic
{
    [TestFixture]
    public class DeterminerDataTests
    {
        [Test]
        public void Article()
        {
            var definitions = Global.Manager.GetDefinitions("an");
            Assert.AreEqual(1, definitions.Records.Length);
            var definition = definitions.Records.First();
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsArticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsCard);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative2);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDeterminer);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsGenitive);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsNumber);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsOrd);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle2);
        }

        [TestCase("two")]
        [TestCase("four")]
        [TestCase("five")]
        public void Card(string word)
        {
            var definitions = Global.Manager.GetDefinitions(word);
            Assert.AreEqual(1, definitions.Records.Length);
            var definition = definitions.Records.First();
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsArticle);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsCard);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative2);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDeterminer);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsGenitive);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsNumber);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsOrd);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle2);
        }

        [Test]
        public void Demonstrative1()
        {
            var definitions = Global.Manager.GetDefinitions("this");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Determiner.HasData);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsArticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsCard);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDemonstrative);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDemonstrative1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative2);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDeterminer);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsGenitive);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsNumber);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsOrd);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle2);
        }

        [Test]
        public void Demonstrative2()
        {
            var definitions = Global.Manager.GetDefinitions("those");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Determiner.HasData);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsArticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsCard);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDemonstrative);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative1);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDemonstrative2);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDeterminer);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsGenitive);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsNumber);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsOrd);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle2);
        }

        [Test]
        public void Genitive()
        {
            var definitions = Global.Manager.GetDefinitions("her");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Determiner.HasData);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsArticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsCard);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative2);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDeterminer);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsGenitive);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsNumber);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsOrd);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle2);
        }

        [Test]
        public void Ord()
        {
            var definitions = Global.Manager.GetDefinitions("last");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Determiner.HasData);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsArticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsCard);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative2);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDeterminer);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsGenitive);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsNumber);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsOrd);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle2);
        }

        [Test]
        public void Prearticle1()
        {
            var definitions = Global.Manager.GetDefinitions("several");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Determiner.HasData);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsArticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsCard);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative2);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDeterminer);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsGenitive);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsNumber);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsOrd);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsPrearticle);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsPrearticle1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle2);
        }

        [Test]
        public void Prearticle2()
        {
            var definitions = Global.Manager.GetDefinitions("some");
            var definition = definitions.Records.First(item => item.Description.Syntactic.Determiner.HasData);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsArticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsCard);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative1);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsDemonstrative2);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsDeterminer);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsGenitive);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsNumber);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsOrd);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsPrearticle);
            Assert.IsFalse(definition.Description.Syntactic.Determiner.IsPrearticle1);
            Assert.IsTrue(definition.Description.Syntactic.Determiner.IsPrearticle2);
        }
    }
}
