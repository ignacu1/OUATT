using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public bool isOnFire;

    public bool isGoingToBeOnFire;

    public GameObject FirePrefab;

    public bool wasOnFire;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isOnFire == true)
        {
            Collider2D[] blocksHit = Physics2D.OverlapCircleAll((Vector2)transform.position, 0.5f, LayerMask.GetMask("Block"));
            foreach(Collider2D block in blocksHit)
            {
                if(block.GetComponent<BlockScript>().isOnFire == false)
                {
                    if(block.GetComponent<BlockScript>().isGoingToBeOnFire == false)
                    {
                        if(block.GetComponent<BlockScript>().wasOnFire == false)
                        {
                            block.GetComponent<BlockScript>().Invoke("SetOnFire", 1f);
                            block.GetComponent<BlockScript>().isGoingToBeOnFire = true;
                            block.GetComponent<BlockScript>().wasOnFire = true;
                        }

                    }
                    
                }
                
            }
            
        }
    }

    public void SetOnFire()
    {
        GameObject myFire = Instantiate(FirePrefab, transform.position, Quaternion.Euler(0, 0, 0));
        myFire.transform.parent = gameObject.transform;
        isOnFire = true;
    }

    public void PutOutTheFire()
    {
        if(isOnFire == true)
        {
        isGoingToBeOnFire = false;
        isOnFire = false;
        Invoke("deleteWasOnFire", 1f);
        GameObject  ChildGameObject = transform.GetChild(0).gameObject;
        Destroy(ChildGameObject);
        }
        
    }

    private void deleteWasOnFire()
    {
        wasOnFire = false;
    }
}
