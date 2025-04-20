class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Item Manager!");

        ItemManager manager = new ItemManager();

        // Part One: Fix the NullReferenceException
        manager.AddItem("Apple");
        manager.AddItem("Banana");

        manager.PrintAllItems();

        // Part Two: Implement the RemoveItem method
        manager.RemoveItem("Apple");

        // Part Three: Introduce a Fruit class and use the ItemManager<Fruit> to add a few fruits and print them on the console.
        ItemManager<Fruit> fruit = new ItemManager<Fruit>();

        fruit.AddItem(new Fruit { name = "Orange" });
        fruit.AddItem(new Fruit { name = "Mango" });
        fruit.AddItem(new Fruit { name = "Durian" });

        fruit.PrintAllItems();

    }
}

public class ItemManager : IItemManager
{
    private List<string> items = new List<string>(); // Part One Fix: Initialize the List

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    // Part Two: Implement the RemoveItem method
    public void RemoveItem(string item)
    {
        items.Remove(item); // Part Two Fix
        Console.WriteLine("Item Removed: " + item);
    }

    public void ClearAllItems()
    {
        items = [];
    }
}

public class ItemManager<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void ClearAllItems()
    {
        items = [];
    }
}

// Part Three: Introduce Fruit Class
public class Fruit
{
    public string name { get; set; }

    public override string ToString()
    {
        return "Fruit: " + name;
    }

}

// Part Four (Bonus): Implement an interface IItemManager and make ItemManager implement it.
public interface IItemManager
{
    void AddItem(string item);
    void PrintAllItems();
    void RemoveItem(string item);
    void ClearAllItems();

}