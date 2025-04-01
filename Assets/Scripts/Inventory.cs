using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Dictionary<string, int> inventory;
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
    void Start()
    {
        inventory = new Dictionary<string, int>{
            {"money", 0},
            {"pickaxelv", 1},
            {"onyx", 0},
            {"agate", 0},
            {"citrine", 0},
            {"garnet", 0},
            {"jadeite", 0},
            {"ruby", 0},
            {"aquamarine", 0},
            {"sapphire", 0},
            {"diamond", 0},
            {"amethyst", 0},
            {"fluorite", 0}
        };
        inventory["money"] += 5;
        print(inventory["money"]);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void addToInventory()
    {
        
    }
}