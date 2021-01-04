using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;

    public float smoothSpeed = 0.125f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Player != null)
        {
            Vector3 desiredPosition = new Vector3(Player.position.x, Player.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
        }
    }
}