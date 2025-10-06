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
            int spawnArea = Random.Range(1, 7);
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
                    Instantiate(newOre, new Vector3(Random.Range(10f, 18f), Random.Range(-17f, -20f)), newOre.transform.rotation);
                    break;
                case 2:
                    Instantiate(newOre, new Vector3(Random.Range(5f, 18f), Random.Range(-20f, -22f)), newOre.transform.rotation);
                    break;
                case 3:
                    Instantiate(newOre, new Vector3(Random.Range(5f, 6f), Random.Range(-13f, -20f)), newOre.transform.rotation);
                    break;
                case 4:
                    Instantiate(newOre, new Vector3(Random.Range(8f, 18f), Random.Range(-16f, -17f)), newOre.transform.rotation);
                    break;
                case 5:
                    Instantiate(newOre, new Vector3(Random.Range(10f, 20f), Random.Range(-12f, -13f)), newOre.transform.rotation);
                    break;
                case 6:
                    Instantiate(newOre, new Vector3(Random.Range(22f, 23f), Random.Range(-8f, -16f)), newOre.transform.rotation);
                    break;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
