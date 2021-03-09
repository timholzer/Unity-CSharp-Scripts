using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDropTables : MonoBehaviour
{
        public static int dropRoll;



public void baseDrop(){
dropRoll= Random.Range(0, 1000);


if (dropRoll <= 250)
{
    //calls a second drop table if you want it share between different sources
    dropTable2();
}
else if (275 >= dropRoll && dropRoll > 250)
{
//add 1 to the quantity of the item with the index of 1
//needs the inventory c# file.
Inventory.inventory[1].quantity++;

}
else if(675 >= dropRoll && dropRoll > 275)
{
Inventory.inventory[2].quantity++;
}
//anything higher equals no drop
}




}