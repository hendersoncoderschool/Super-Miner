using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject shop;
    public CameraController gameCam;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        print("done");
        shop.SetActive(true);
        gameCam.scrolling = true;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            shop.SetActive(false);
            gameCam.scrolling = false;
        }
    }
}
