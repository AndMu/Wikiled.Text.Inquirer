# Inquirer C# API Based on Harward General Inquirer

![Nuget](https://img.shields.io/nuget/v/Wikiled.Text.Inquirer.svg)


The General Inquirer is basically a mapping tool. It maps each text file with counts on dictionary-supplied categories.  The currently distributed version combines the "Harvard IV-4" dictionary content-analysis categories, the "Lasswell" dictionary content-analysis categories, and five categories based on the social cognition work of Semin and Fiedler, making for 182 categories in all.  Each category is a list of words and word senses. A category such as "self references" may contain only a dozen entries, mostly pronouns. Currently, the category "negative" is our largest with 2291 entries.  Users can also add additional categories of any size. 

More information on [Harward General Inquirer](http://www.wjh.harvard.edu/~inquirer/3JMoreInfo.html)


```C#
var manager = new InquirerManager();
manager.Load();
var definitions = manager.GetDefinitions("body");
```