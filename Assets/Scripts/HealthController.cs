using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public bool destroyWhenDead = true;

    public void Damage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            if (destroyWhenDead)
                Destroy(gameObject);
        }

    }

    public void Heal()
    {
        health = maxHealth;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
