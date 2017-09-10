using NUnit.Framework;
using Wikiled.Text.Inquirer.Logic;

namespace Wikiled.Text.Inquirer.Tests.Logic
{
    [SetUpFixture]
    public class Global
    {
        public static InquirerManager Manager { get; private set; }

        [OneTimeSetUp]
        public void Setup()
        {
            Manager = new InquirerManager();
            Manager.Load();
        }

        [OneTimeTearDown]
        public void Clean()
        {
        }
    }
}
