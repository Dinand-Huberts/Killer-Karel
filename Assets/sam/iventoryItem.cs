using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface iventoryItem
{
    string Name { get; }
    
    Sprite Image { get; }

    void OnPickup();
}

public class InventoryEventArgs : EventArgs
{
    public InventoryEventArgs(IInventoryItem item)
    {
        Item = item;
    }

    public IInventoryItem Item;
}