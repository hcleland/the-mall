namespace TheMall
{
    public interface IStore<TItem>
    {
        // Methods
        void AddToInventory(string name, TItem item);

        TItem GetFromInventory(string name);
    }
}