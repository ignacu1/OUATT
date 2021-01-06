using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public float maxHealth;
    public float currentHealth;
    public Text healthText;
    public GameObject playerHand;

    private float audioTimer;
    public float audioTime;

    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        audioTimer = audioTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Die();
            
        }

        if(currentHealth >= 0 && currentHealth < 100){
            healthText.text = "HEALTH: " + currentHealth.ToString();
        }
    }

    void TakeDamagePlayer(float damage)
    {
        if(audioTimer <= 0)
        {
            FindObjectOfType<AudioManagerScript>().Play("Hurt");
            audioTimer = audioTime;
        } else if(audioTimer > 0)
        {
            audioTimer -= Time.deltaTime;
        }
        currentHealth -= damage * Time.deltaTime;
    }

    void Die(){
        Destroy(gameObject);
        Destroy(playerHand);
    }

    void OnCollisionStay2D(Collision2D collisionInfo){
        if(collisionInfo.collider.tag == "enemy"){
            TakeDamagePlayer(50);
        }

        if(collisionInfo.collider.tag == "bigEnemy"){
            TakeDamagePlayer(60);
        }


    }



    
}
