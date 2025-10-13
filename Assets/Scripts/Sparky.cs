using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparky : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(dieoff());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator dieoff()
    {
        yield return new WaitForSeconds(0.33f);
        Destroy(gameObject);
    }
}
