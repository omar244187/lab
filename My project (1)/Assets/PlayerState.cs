using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public int health=3;
    public int lives=3;

    private float flickertime=0f;
public float flickerduration=0.1f;

private SpriteRenderer sr;
public bool isimmune=false;
private float immunityTime=0f;
public float immunityDuration=2f;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isimmune == true)
        {
            immunityTime = immunityTime + Time.deltaTime;
            spriteflicker();
        }
        if (immunityTime >= immunityDuration)
        {
            isimmune = false;
            sr.enabled = true;
        }
        
    }
    void spriteflicker()
    {
        
        if (flickertime < flickerduration)
        {
            flickertime = flickertime + Time.deltaTime;
        }
        else if (flickertime >= flickerduration)
        {
         
            sr.enabled = !(sr.enabled);
               flickertime = 0f;
        }
    }

    public void takeDamage(int damage)
    {
       if (isimmune == false)
       {
           health = health - damage;
           if(health < 0)
           {
               health = 0;
           }
           if (lives > 0 && health == 0)
           {
               FindObjectOfType<LevelManager>().RespawnPlayer();
               health = 3;
               lives--;
           }
           else if (lives == 0 )
           {
               Debug.Log("Game Over");
               Destroy(this.gameObject);
           }
           Debug.Log("Player Health: " + health.ToString() );
           Debug.Log("Player Lives: " + lives.ToString());
       }
       isimmune = true;
       immunityTime = 0f;
    }
}
