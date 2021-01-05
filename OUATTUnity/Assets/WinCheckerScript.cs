using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheckerScript : MonoBehaviour
{
    
    public static int AmmountOfBlocks;
    public static int AmmountOfNotBurningBlocks;
    public static int AmmountOfBurningBlocks;
    public static int AmmountOfGoingToBurnBlocks;

    private bool won;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(AmmountOfBlocks + ", " + AmmountOfNotBurningBlocks + ", " + AmmountOfBurningBlocks + ", " + AmmountOfGoingToBurnBlocks);
        if(AmmountOfBurningBlocks == 0 && AmmountOfGoingToBurnBlocks <= 0 && won == false)
        {
            Win();
        }
    }

    void Win()
    {
        Debug.Log("Win");
        won = true;
    }
}