using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{

    public float distance;
    public float speed;
    public Transform playerPos;

    public RaycastScript RaycastScript;

    public float maxHealthEnemy;

    private Rigidbody2D rb;
    

    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, playerPos.position) < distance)
        {
            GetComponent<Animator>().SetBool("isWalking", true);
            rb.MovePosition(Vector2.MoveTowards(transform.position, new Vector2(playerPos.position.x, transform.position.y), speed * Time.deltaTime));
            if(transform.position.x < playerPos.position.x)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            } else if(transform.position.x > playerPos.position.x)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }else
        {
            GetComponent<Animator>().SetBool("isWalking", false);
        }

        if(maxHealthEnemy <= 0f)
        {
            Die();
        }

        
    }

    public void TakeDamage(int damage)
    {
        maxHealthEnemy -= damage;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
