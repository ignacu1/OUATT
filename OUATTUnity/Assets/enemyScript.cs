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
    

    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, playerPos.position) < distance){
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(playerPos.position.x, transform.position.y), speed * Time.deltaTime);
        }

        if(maxHealthEnemy <= 0f){
            Die();
        }
    }

    public void TakeDamage(int damage){
        maxHealthEnemy -= damage;

        
    }

    public void Die(){
        Destroy(gameObject);
    }
}
