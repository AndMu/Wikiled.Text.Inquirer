namespace Wikiled.Text.Inquirer.Reflection.Data
{
    public class ItemProbability<T> : IItemProbability<T>
    {
        public ItemProbability()
        {
            
        }

        public ItemProbability(T item)
        {
            Data = item;
        }

        public T Data { get; }

        public double Probability { get; set; }
    }
}
