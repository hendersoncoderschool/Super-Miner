using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float lerpSpeed;
    public float yTop;
    public float yBottom;
    private bool scrolling;
    public void moveCamera(Vector3 destination, bool direction){
        scrolling = true;
        StartCoroutine(lerpCam(destination, direction));
    }
    private IEnumerator lerpCam(Vector3 destination, bool direction){
        if (direction){
            yTop = destination.y;
            yBottom = destination.y -4f;
        }else{
            yTop = destination.y + 4f;
            yBottom = destination.y;
        }
        while(Vector3.Distance(transform.position, destination) > 0.01f){
            transform.position = Vector3.Lerp(transform.position, destination, Time.deltaTime * lerpSpeed);
            yield return new WaitForSeconds(0.01f);
        }
        transform.position = new Vector3(destination.x, destination.y, destination.z);
        scrolling = false;
        print("done");
    }
    // Start is called before the first frame update
    void Start()
    {
        scrolling = false;
        yTop = 3f;
        yBottom = -1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!scrolling){
        float offset = Input.GetAxis("Mouse ScrollWheel");

        Vector3 newPos = transform.position + new Vector3(0f, offset * 10f, 0f);

        transform.position = newPos;

        if(transform.position.y > yTop){
            transform.position = new Vector3(transform.position.x, yTop, transform.position.z);
        }
        else if(transform.position.y < yBottom){
            transform.position = new Vector3(transform.position.x, yBottom, transform.position.z);
        }
        }
    }
}
