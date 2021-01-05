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

    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Die();
            
        }

        if(currentHealth >= 0){
            healthText.text = "HEALTH: " + currentHealth.ToString();
        }
    }

    void TakeDamagePlayer(float damage){
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
    }
}
