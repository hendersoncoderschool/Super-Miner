using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawn : MonoBehaviour
{
    public GameObject onyx;
    public GameObject agate;
    public GameObject citrine;
    public GameObject garnet;

    // spawn area 1 : x 3.5, 9 y -1, 2
    // spawn area 2 : x -6, 6 y -1, -2
    // spawn area 3 : x -9, -8 y 2, -5
    // spawn area 4 : x -9, 6 y -5, -6
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GemSpawner());
    }

    IEnumerator GemSpawner(){
        while(true){
            yield return new WaitForSeconds(Random.Range(10f, 40f));
            int spawnArea = Random.Range(1, 4);
            int oreRoll = Random.Range(0, 100);
            GameObject newOre =  null;
            if(oreRoll < 40)
            {
                newOre = onyx;
            }
            else if(oreRoll >= 40 && oreRoll < 70)
            {
                newOre = agate;
            }
            else if (oreRoll >= 70 && oreRoll < 90)
            {
                newOre = citrine;
            }
            else if (oreRoll >= 90 && oreRoll <= 100)
            {
                newOre = garnet;
            }
            switch (spawnArea){
                case 1:
                    Instantiate(newOre, new Vector3(Random.Range(3.5f, 9f), Random.Range(-1f, 2f)), newOre.transform.rotation);
                    break;
                case 2:
                    Instantiate(newOre, new Vector3(Random.Range(-6f, 6f), Random.Range(-1f, -2f)), newOre.transform.rotation);
                    break;
                case 3:
                    Instantiate(newOre, new Vector3(Random.Range(-9f, -8f), Random.Range(2f, -5f)), newOre.transform.rotation);
                    break;
                case 4:
                    Instantiate(newOre, new Vector3(Random.Range(-9f, 6f), Random.Range(-5f, -6f)), newOre.transform.rotation);
                    break;
            }
        }
}

    void Update()
    {

    }
}
