using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public int Health { get; set; }

    void Start()
    {
        Health = 50;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Debug.Log("Enemy died.");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Enemy took damage. Current Health: " + Health);
        }
    }

    public void Heal(int amount)
    {
        Health += amount;
        Debug.Log("Enemy healed. Current Health: " + Health);
    }
}