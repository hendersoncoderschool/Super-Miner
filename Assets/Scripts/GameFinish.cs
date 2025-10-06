using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFinish : MonoBehaviour
{
    public GameObject FinishedUI;
    public CameraController gameCam;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        print("done");
        if (!GameObject.Find("Main Camera").GetComponent<CameraController>().scrolling)
        {
            FinishedUI.SetActive(true);
            gameCam.scrolling = true;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            FinishedUI.SetActive(false);
            gameCam.scrolling = false;
            Destroy(gameObject);

        }
    }
}
