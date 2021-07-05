using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float shotSpeed = 5f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    Player target;
    Vector2 targetDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        targetDirection = (target.transform.position - transform.position)* shotSpeed;
        rb.velocity = new Vector2 (targetDirection.x, targetDirection.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
