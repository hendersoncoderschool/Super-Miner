using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawn3 : MonoBehaviour
{
    public GameObject sapphire;
    public GameObject diamond;
    public GameObject amethyst;
    public GameObject fluorite;

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
            if (oreRoll < 45)
            {
                newOre = sapphire;
            }
            else if (oreRoll >= 45 && oreRoll < 70)
            {
                newOre = diamond;
            }
            else if (oreRoll >= 70 && oreRoll < 98)
            {
                newOre = amethyst;
            }
            else if (oreRoll >= 98 && oreRoll <= 100)
            {
                newOre = fluorite;
            }
            switch (spawnArea)
            {
                case 1:
                    Instantiate(newOre, new Vector3(Random.Range(3.5f, 9f), Random.Range(-1f, 2f)), newOre.transform.rotation);
                    break;
                case 2:
                    Instantiate(newOre, new Vector3(Random.Range(-6f, 6f), Random.Range(-1f, -2f)), newOre.transform.rotation);
                    break;
                case 3:
                    Instantiate(newOre, new Vector3(Random.Range(-9f, -8f), Random.Range(2f, -5f)), newOre.transform.rotation);
                    break;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
