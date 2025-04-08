using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawn2 : MonoBehaviour
{
    public GameObject jadeite;
    public GameObject ruby;
    public GameObject aquamarine;

    // spawn area 1 : x 11, 28 y 2, -2
    // spawn area 1 : x 11, 25 y -2, -5
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GemSpawner());
    }
    IEnumerator GemSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(10f, 40f));
            int spawnArea = Random.Range(1, 4);
            int oreRoll = Random.Range(0, 100);
            GameObject newOre = null;
            if (oreRoll < 50)
            {
                newOre = jadeite;
            }
            else if (oreRoll >= 50 && oreRoll < 95)
            {
                newOre = ruby;
            }
            else if (oreRoll >= 95 && oreRoll <= 100)
            {
                newOre = aquamarine;
            }
            switch (spawnArea)
            {
                case 1:
                    Instantiate(newOre, new Vector3(Random.Range(11f, 28f), Random.Range(2f, -2f)), newOre.transform.rotation);
                    break;
                case 2:
                    Instantiate(newOre, new Vector3(Random.Range(11f, 25f), Random.Range(-2f, -5f)), newOre.transform.rotation);
                    break;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
