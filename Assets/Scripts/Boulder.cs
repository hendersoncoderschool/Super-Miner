using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    public int health;
    private float maxHealth;
    public GameObject GemSpawn2;
    public GameObject Door1_2;
    public GameObject Inventory;
    public GameObject HealthBar;
    public GameObject sparkEffect;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
        Inventory = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        health -= (int)Mathf.Pow(2f, (float)Inventory.GetComponent<Inventory>().pickaxelv-1f);
        Vector3 newScale = HealthBar.transform.localScale;
        newScale.x = 0.25f * health / maxHealth;
        HealthBar.transform.localScale = newScale;
        print(health);
        if(health <= 0){
            GemSpawn2.SetActive(true);
            Door1_2.SetActive(true);
            Destroy(gameObject);
        }
        Vector3 mousePositionWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePositionWorld.z = -1;
        Instantiate(sparkEffect, mousePositionWorld, Quaternion.identity);
    }
}
