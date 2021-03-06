using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Items> itemlist;

    public Inventory()
    {
        itemlist = new List<Items>();
        pick(new Items { itemtype = Items.itemType.Sword, amount = 1 });
        Debug.Log(itemlist.Count);

    }

    public void pick(Items item)
    {
        itemlist.Add(item);
    }

    public void drop(Items item)
    {
        itemlist.Remove(item);
    }

}
