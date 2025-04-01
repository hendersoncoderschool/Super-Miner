using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTransition : MonoBehaviour
{
    public bool direction;
    public Vector3 destination;
    private void OnMouseDown(){
        print("done");
    GameObject.Find("Main Camera").GetComponent<CameraController>().moveCamera(
        destination, direction);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
