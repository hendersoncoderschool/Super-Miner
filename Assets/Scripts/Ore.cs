using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    public int health;
    public string type;
    public GameObject Inventory;
    public GameObject sparkEffect;
    // Start is called before the first frame update
    void Start()
    {
        Inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        health -= (int)Mathf.Pow(2f, (float)Inventory.GetComponent<Inventory>().pickaxelv - 1f);
        print(health);
        if(health <= 0){
            GameObject.Find("Inventory").GetComponent<Inventory>().addToInventory(type);
            Destroy(gameObject);
        }
        Vector3 mousePositionWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePositionWorld.z = -5;
        Instantiate(sparkEffect, mousePositionWorld, Quaternion.identity);
    }
}
