using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public bool isOnFire;

    public bool isGoingToBeOnFire;

    public GameObject FirePrefab;

    public bool wasOnFire;

    public bool isGoingToSetOnFireAtStart;

    void Start()
    {
        if(isGoingToSetOnFireAtStart == true)
        {
            SetOnFire();
            WinCheckerScript.AmmountOfGoingToBurnBlocks += 1;
        }
    }


    private void Awake() 
    {
        WinCheckerScript.AmmountOfBlocks += 1;
        WinCheckerScript.AmmountOfNotBurningBlocks += 1;

        int rand = Random.Range(1, 3);
        if(rand == 1)
        {
            isGoingToSetOnFireAtStart = true;
        }

        if(rand == 2)
        {
            isGoingToSetOnFireAtStart = false;
        }
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
                            WinCheckerScript.AmmountOfGoingToBurnBlocks += 1;
                        }

                    }
                    
                }
                
            }
            
        }
    }

    public void SetOnFire()
    {
        WinCheckerScript.AmmountOfNotBurningBlocks -= 1;
        WinCheckerScript.AmmountOfBurningBlocks += 1;
        GameObject myFire = Instantiate(FirePrefab, transform.position, Quaternion.Euler(0, 0, 0));
        myFire.transform.parent = gameObject.transform;
        isOnFire = true;
    }

    public void PutOutTheFire()
    {
        if(isOnFire == true)
        {
            WinCheckerScript.AmmountOfNotBurningBlocks += 1;
            WinCheckerScript.AmmountOfBurningBlocks -= 1;
            GameObject  ChildGameObject = transform.GetChild(0).gameObject;
            Destroy(ChildGameObject);
            isGoingToBeOnFire = false;
            isOnFire = false;
            wasOnFire = true;
            Invoke("deleteWasOnFire", 2f);
            WinCheckerScript.AmmountOfGoingToBurnBlocks -= 1;
            FindObjectOfType<AudioManagerScript>().Play("WaterSplash");
        }
        
    }

    private void deleteWasOnFire()
    {
        wasOnFire = false;
    }
}
