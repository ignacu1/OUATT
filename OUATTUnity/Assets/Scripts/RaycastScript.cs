using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{

    public Transform raycastPos;
    public GameObject waterParticles;

    public float reach;

    public float radius;

    

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
            Collider2D[] blocksHit = Physics2D.OverlapCircleAll(hit.point, radius, LayerMask.GetMask("Block"));
            foreach(Collider2D block in blocksHit)
            {
                if(block.GetComponent<BlockScript>().isOnFire == true)
                {
                    Instantiate(waterParticles, block.transform.position, Quaternion.Euler(0, 0, 0));
                }
                block.GetComponent<BlockScript>().PutOutTheFire();
            }

        } else 
        {
            
        }

        if(hit.collider.tag == "enemy" && Input.GetButtonDown("Fire1"))
        {
            hit.collider.gameObject.GetComponent<enemyScript>().TakeDamage(20);
            Instantiate(waterParticles, hit.transform.position, Quaternion.Euler(0, 0, 0));
            Debug.Log("test");
        }
    }
}