using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   

    }

    void SwitchTarget()
    {
                Debug.Log("Switchvam lek");
                spriteRenderer.color = Color.blue;
                gameObject.tag = "EnemyKiller";
    }

    void Kill()
    {      
                Debug.Log("Ubivam lekiq");
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
