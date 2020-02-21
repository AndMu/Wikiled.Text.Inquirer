using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wikiled.Common.Extensions;
using Wikiled.Common.Helpers;
using Wikiled.Common.Resources;
using Wikiled.Text.Inquirer.Data;

namespace Wikiled.Text.Inquirer.Logic
{
    public class InquirerManager : IInquirerManager
    {
        private readonly Dictionary<string, List<InquirerRecord>> items = new Dictionary<string, List<InquirerRecord>>(StringComparer.OrdinalIgnoreCase);

        private bool isLoaded = false;

        public int Total => items.Count;

        public InquirerDefinition GetDefinitions(string word)
        {
            if (!isLoaded)
            {
                throw new InvalidOperationException("Not loaded");
            }

            if (string.IsNullOrEmpty(word))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(word));
            }

            if (items.TryGetValue(word, out var definitions))
            {
                return new InquirerDefinition(word, definitions.ToArray());
            }

            return new InquirerDefinition(word, new InquirerRecord[] { });
        }

        public void Load()
        {
            isLoaded = true;
            ReadDataFromInternalStream();
        }

        private void ReadDataFromInternalStream()
        {
            using (BinaryReader reader = new BinaryReader(typeof(InquirerManager).GetEmbeddedFile(@"Resources.inquirer.dat")))
            {
                byte[] data = new byte[reader.BaseStream.Length];
                reader.Read(data, 0, data.Length);
                var unzipedText = data.UnZipString();
                int i = 0;
                foreach (var line in unzipedText.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    i++;
                    if (i == 1)
                    {
                        continue;
                    }

                    var entries = line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    string word = string.Intern(entries[0]);
                    int idIndex = word.IndexOf("#");
                    if (idIndex > 0)
                    {
                        word = word.Substring(0, idIndex);
                    }

                    items.GetSafeCreate(word).Add(new InquirerRecord(word, entries.Skip(1).ToArray()));
                }
            }
        }
    }
}
