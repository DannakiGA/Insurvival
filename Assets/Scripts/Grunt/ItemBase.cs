public class ItemBase<T>
{
    T itemType;
    int count;

    public int Count
    {
        get
        {
            return count;
        }

        set
        {
            count += value;
        }
    }

    public ItemBase(T itemType, int count)
    {
        this.itemType = itemType;
        this.count = count;
    }
}
