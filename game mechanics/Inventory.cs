
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iventory : MonoBehaviour {




public int id;
public string itemName;
public int quantity;
public int lvlReq;
public int stat1;
public int stat2;
public int sellPrice;
public string description;
//you can add more variables to tie to your items here

public Iventory(int id, string itemName, int quantity, int lvlReq, int stat1, int stat2, int sellPrice, string description )
    {
        this.id = id;
        this.itemName = itemName;
        this.quantity = quantity;
        this.lvlReq = lvlReq;
        this.powermult = powermult;
        this.durationmult = durationmult;
        this.sellPrice = sellPrice;
        this.description = description;
    }

    public static List<Inventory> inventory = new List<Inventory>()
 
    {
        //id starts at zero so it's the same as the index when calling the item
    new Inventory(0, "example item", 0, 0, 0, 0, 0, "this item is an example"),
    new Inventory(1, "item 2", 0, 1, 1, 1, 0, "another item"),
    new Inventory(2, "item 3", 0, 2, 1, 1, 0, "yeah, that's right, there are now 3 items in this game")

    };









}