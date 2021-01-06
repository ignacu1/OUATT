using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winScreen : MonoBehaviour
{
    public GameObject winScreenn;
    public GameObject StartMenu;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToNextLevel(){
        winScreenn.SetActive(false);
        SceneManager.LoadScene("scena2");
    }

    public void retryLevel(){
        winScreenn.SetActive(false);
        SceneManager.LoadScene("scena1");
    }

    public void goToMenu(){
        winScreenn.SetActive(false);
        StartMenu.SetActive(true);
    }
}
