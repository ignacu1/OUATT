using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastScript : MonoBehaviour
{

    public Transform raycastPos;
    //public float distance;

    

    //public LayerMask mask;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        Ray ray = new Ray(raycastPos.position, raycastPos.up);

        RaycastHit2D hit = Physics2D.Raycast(raycastPos.position, raycastPos.TransformDirection(Vector2.down), 10f);
        
        if(hit){
            Debug.Log("test");
            Debug.DrawRay(raycastPos.position, raycastPos.TransformDirection(Vector2.down) * 10f);
            hit.transform.GetComponent<SpriteRenderer>().color = Color.blue;
        }


        
    }
}
