using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour
{
    public int health;
    public GameObject GemSpawn2;
    public GameObject Door1_2;
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
            GemSpawn2.SetActive(true);
            Door1_2.SetActive(true);
            Destroy(gameObject);
        }
    }
}
