using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 30f;
    public float minY = 15f, maxY = 80f;

    // Update is called once per frame
    void Update()
    {
        // Move camera up
        if( Input.GetKey("w") )
        {
            transform.Translate( Vector3.forward * cameraSpeed * Time.deltaTime, Space.World);
        }
        // Move camera down
        if( Input.GetKey("s") )
        {
            transform.Translate( Vector3.back * cameraSpeed * Time.deltaTime, Space.World);
        }
        // Move camera to the left
        if( Input.GetKey("a") )
        {
            transform.Translate( Vector3.left * cameraSpeed * Time.deltaTime, Space.World);
        }
        // move camera to the right
        if( Input.GetKey("d") )
        {
            transform.Translate( Vector3.right * cameraSpeed * Time.deltaTime, Space.World);
        }

        // Zoom in
        if( Input.GetKey("i") )
        {
            Vector3 viewPos =  transform.position;
            if( viewPos.y > minY)
            {
                transform.Translate( Vector3.down * cameraSpeed * Time.deltaTime, Space.World);
            }
        }

        // Zoom out 
        if( Input.GetKey("o") )
        {
            Vector3 viewPos =  transform.position;
            if( viewPos.y < maxY)
            {
                transform.Translate( Vector3.up * cameraSpeed * Time.deltaTime, Space.World);
            }
        }
    }
}
