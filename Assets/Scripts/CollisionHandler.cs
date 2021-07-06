using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {   

    }

    void SwitchTarget()
    {
                spriteRenderer.color = Color.blue;
                gameObject.tag = "EnemyKiller";
    }

    void Kill()
    {      
                Destroy(gameObject);

    }

    void OnCollisionEnter2D(Collision2D other) 
        {   
            if (other.gameObject.tag == "Mirror")
            {
                SwitchTarget();
            }

            if (other.gameObject.tag == "Enemy")
            {
            Kill();
            Destroy(other.gameObject);
            }
        }

}
