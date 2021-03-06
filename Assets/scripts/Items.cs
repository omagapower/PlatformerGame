using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    // Start is called before the first frame update
    public enum itemType
    {
        Sword,
        HealthPotion,
        ManaPotion,
        Coin,
    }

    public itemType itemtype;
    public int amount;  
}
