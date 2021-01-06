using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemyScript : MonoBehaviour
{

    public Transform playerPos;
    public float bigEnemyHealth = 100f;
    public float speed;
    public float distance;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, playerPos.position) < distance){
            rb.MovePosition(Vector2.MoveTowards(transform.position, new Vector2(playerPos.position.x, transform.position.y), speed * Time.deltaTime));
        }

        if(bigEnemyHealth <= 0f){
            Die();
        }
    }

    public void TakeDamage(int damage){
        bigEnemyHealth -= damage;
    }

    public void Die(){
        Destroy(gameObject);
    }
}
