using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    public int Health { get; set; }

    void Start()
    {
        Health = 100;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Debug.Log("Player died.");
        }
        else
        {
            Debug.Log("Player took damage. Current Health: " + Health);
        }
    }

    public void Heal(int amount)
    {
        Health += amount;
        Debug.Log("Player healed. Current Health: " + Health);
    }
}
