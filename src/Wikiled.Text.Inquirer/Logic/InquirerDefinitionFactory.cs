using System.Collections.Generic;
using System.Linq;
using NLog;
using Wikiled.Common.Extensions;
using Wikiled.Text.Analysis.Reflection;
using Wikiled.Text.Analysis.Reflection.Data;
using Wikiled.Text.Inquirer.Data;
using Wikiled.Text.Inquirer.Harvard;

namespace Wikiled.Text.Inquirer.Logic
{
    public class InquirerDefinitionFactory
    {
        public static readonly InquirerDefinitionFactory Instance = new InquirerDefinitionFactory();

        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        private static readonly IMapCategory map = new CategoriesMapper().Construct<InquirerDescription>();

        private readonly Dictionary<string, bool> ignoreTable = new Dictionary<string, bool>();

        private InquirerDefinitionFactory()
        {
            ignoreTable["H4"] = true;
            ignoreTable["H4Lvd"] = true;
            ignoreTable["Pstv"] = true;
            ignoreTable["Ngtv"] = true;
            ignoreTable["Positiv"] = true;
            ignoreTable["Negativ"] = true;
            ignoreTable["Lvd"] = true;
            ignoreTable["COM"] = true;
        }

        public InquirerDescription Construct(InquirerRecord record)
        {
            InquirerDescription description = new InquirerDescription();
            ILookup<string, string> lookup = record.RawCategories.ToLookup(item => item, item => item);
            if (lookup.Contains("Positiv"))
            {
                description.Harward.Sentiment = new SentimentData(PositivityType.Positive);
            }

            if (lookup.Contains("Negativ"))
            {
                description.Harward.Sentiment = new SentimentData(PositivityType.Negative);
            }

            DataTree tree = new DataTree(description, map);
            var leafLookup = tree.AllLeafs.ToLookup(item => item.Name);
            int total = 0;
            foreach (var category in record.RawCategories)
            {
                total++;
                if (total == record.RawCategories.Length)
                {
                    int index = category.IndexOf("|");
                    description.Information = index == 0
                                                  ? category.Substring(1)
                                                            .Trim()
                                                  : category;
                }
                else if (string.IsNullOrEmpty(category) ||
                         ignoreTable.ContainsKey(category))
                {
                }
                else
                {
                    ParseSubCategories(category, leafLookup, description);
                }
            }

            return description;
        }

        private static void ParseSubCategories(string category, ILookup<string, IDataItem> leafLookup, InquirerDescription description)
        {
            var subCategories = category.Split(' ');
            List<string> unknown = new List<string>();
            foreach (var item in subCategories)
            {
                if (!map.ContainsField(item))
                {
                    unknown.Add(item);
                }
                else
                {
                    foreach (var dataItem in leafLookup[item])
                    {
                        dataItem.Value = true;
                    }
                }
            }

            if (unknown.Count > 0)
            {
                description.OtherTags = unknown.AccumulateItems(" ");
                log.Debug($"Other tags: {description.OtherTags}");
            }
        }
    }
}