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

    public ItemBase(T itemType, int count = 0)
    {
        this.itemType = itemType;
        this.count = count;
    }

    public bool EqualItem(T item)
    {
        if(itemType.Equals(item))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
