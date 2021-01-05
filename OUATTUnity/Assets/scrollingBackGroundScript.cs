using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingBackGroundScript : MonoBehaviour
{

    public bool ResetedBackground1 = false;
    public Transform point1;
    public Transform point2;
    public Transform BG1;
    public Transform BG2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, point1.position) < 5 && ResetedBackground1 == false){
            ResetBackground1();
        }

        if(Vector3.Distance(transform.position, point2.position) < 5 && ResetedBackground1 == true){
            ResetBackground2();
        }
    }

    void ResetBackground1(){
        BG2.position = new Vector3(BG1.position.x + 24.5f, BG2.position.y, BG2.position.z);
        ResetedBackground1 = true;
    }

    void ResetBackground2(){
        BG1.position = new Vector3(BG2.position.x + 24.5f, BG1.position.y, BG1.position.z);
        ResetedBackground1 = false;
    }   
}
