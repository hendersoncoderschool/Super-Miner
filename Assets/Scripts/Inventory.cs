using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Dictionary<string, int> inventory;
    Dictionary<string, int> Values;
    public int money;
    public int pickaxelv;
    /*public int Money;
    public int PickaxeLv;
    public int Onyx;
    public int Agate;
    public int Citrine;
    public int Garnet;
    public int Jadeite;
    public int Ruby;
    public int Aquamarine;
    public int Sapphire;
    public int Diamond;
    public int Amethyst;
    public int Fluorite;
    */
    public void SellItems()
    {
        foreach(var item in new List<string>(inventory.Keys)){
            money += Values[item] * inventory[item];
            inventory[item] = 0;
        }
        print(money);
    }

    void Start()
    {
        inventory = new Dictionary<string, int>{
            {"onyx", 0}, //1
            {"agate", 0}, //2
            {"citrine", 0}, //3
            {"garnet", 0}, //5
            {"jadeite", 0}, //10
            {"ruby", 0}, //15
            {"aquamarine", 0}, //20
            {"sapphire", 0}, //45
            {"diamond", 0}, //70
            {"amethyst", 0}, //100
            {"fluorite", 0} //250
        };

        Values = new Dictionary<string, int>{
            {"onyx", 1}, //1
            {"agate", 2}, //2
            {"citrine", 3}, //3
            {"garnet", 5}, //5
            {"jadeite", 10}, //10
            {"ruby", 15}, //15
            {"aquamarine", 20}, //20
            {"sapphire", 45}, //45
            {"diamond", 70}, //70
            {"amethyst", 100}, //100
            {"fluorite", 250} //250
        };

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void addToInventory(string type)
    {
        inventory[type] += 1;

        Debug.Log(type +":" + inventory[type].ToString());
    }
}