using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float maxHealth;
    public float currentHealth;
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
    }

    void TakeDamagePlayer(float damage){
        currentHealth -= damage * Time.deltaTime;
    }

    void Die(){
        Destroy(gameObject);
    }

    void OnCollisionStay2D(Collision2D collisionInfo){
        if(collisionInfo.collider.tag == "enemy"){
            TakeDamagePlayer(50);
        }
    }
}
