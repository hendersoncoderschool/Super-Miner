using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    public int health;
    public string type;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        health -= 1;
        print(health);
        if(health <= 0){
            GameObject.Find("Inventory").GetComponent<Inventory>().addToInventory(type);
            Destroy(gameObject);
        }
    }
}
