using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathMenuScript : MonoBehaviour
{
    public GameObject deathMenuUI;
    public PlayerHealth PlayerHealth;
    public GameObject startMenuUI;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerHealth.currentHealth <= 0f){
            deathMenuUI.SetActive(true);
        }
    }

    public void Retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        startMenuUI.SetActive(false);
        
    }

    public void QuitGame(){
        Application.Quit();
        
    }
}
