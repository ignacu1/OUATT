using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRotationScript : MonoBehaviour
{
    
    public Camera cam;

    private Vector2 mousePos;

    public Transform Player;

    void Start()
    {
        
    }

    
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(Player.position.x, Player.position.y + 0.25f, Player.position.z);
    }

    private void FixedUpdate() 
    {
        Vector2 lookDir = mousePos - new Vector2(transform.position.x, transform.position.y);
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, angle);
    }
}
