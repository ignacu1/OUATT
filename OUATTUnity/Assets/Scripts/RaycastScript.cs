using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{

    public Transform raycastPos;
    public GameObject waterParticles;

    public float reach;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(raycastPos.position, raycastPos.up);

        RaycastHit2D hit = Physics2D.Raycast(raycastPos.position, raycastPos.TransformDirection(Vector2.down), reach);
        Debug.DrawRay(raycastPos.position, raycastPos.TransformDirection(Vector2.down) * reach);
        
        if(hit.collider.tag == "block" && Input.GetButtonDown("Fire1"))
        {
            hit.transform.GetComponent<BlockScript>().PutOutTheFire();
            Instantiate(waterParticles,(Vector3)hit.point, Quaternion.Euler(0, 0, 0));

        } else 
        {
            
        }
    }
}
