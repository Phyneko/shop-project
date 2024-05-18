using System;
using System.Collections.Generic;
public class Inventory 
{
    private Dictionary<ItemData, int> inventory = new();

    public Inventory() { }

    public Inventory(List<InitialInventory> initialInventory)
    {
        for (int i = 0; i < initialInventory.Count; i++)
            AddItem(initialInventory[i].item, initialInventory[i].quantity);

        initialInventory.Clear();
    }

    public void AddItem(ItemData item, int quantity)
    {
        if (inventory.ContainsKey(item))
        {
            inventory[item] += quantity;
            return;
        }

        inventory.Add(item, quantity);
    }

    public bool CanRemove(ItemData item, int quantity)
    {
        if(!inventory.ContainsKey(item)) return false;
        if (inventory[item] < quantity) return false;
        return true;
    }

    public void RemoveItem(ItemData item, int quantity)
    {
        if (!CanRemove(item, quantity)) return;
        if (!inventory.ContainsKey(item)) return;

        inventory[item] -= quantity;

        if (inventory[item] <= 0)
            inventory.Remove(item);
    }

    public Dictionary<ItemData, int> GetInventory() => inventory;
}

[Serializable]
public class InitialInventory
{
    public ItemData item;
    public int quantity;
}
