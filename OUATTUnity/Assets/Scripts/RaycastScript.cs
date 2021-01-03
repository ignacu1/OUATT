using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{

    public Transform raycastPos;
    public BlockScript BlockScript;
    //public float distance;
    public GameObject fire;
    public GameObject block;

    

    //public LayerMask mask;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        Ray ray = new Ray(raycastPos.position, raycastPos.up);

        RaycastHit2D hit = Physics2D.Raycast(raycastPos.position, raycastPos.TransformDirection(Vector2.down), 10f);
        
        if(hit.collider.tag == "block" && Input.GetButtonDown("Fire1"))
        {
            
            Debug.Log("test");
            Debug.DrawRay(raycastPos.position, raycastPos.TransformDirection(Vector2.down) * 10f);
            hit.transform.GetComponent<BlockScript>().PutOutTheFire();

        } else {
            
        }


        
    }
}
