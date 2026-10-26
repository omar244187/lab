using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float maxspeed=2;
    public int damage=1;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
public void flip()
    {
        sr.flipX = !sr.flipX;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Player")
        {
           FindObjectOfType<PlayerState>().takeDamage(damage);
        flip();
        }
        else if (other.tag=="wall")
        {
            flip();
        }
    }
}
