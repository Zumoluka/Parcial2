using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public UnityEvent onPlayerDeath;
    private int health = 100;

    void Update()
    {
        if (health <= 0)
        {
            // evento cuando muere del jugador
            onPlayerDeath.Invoke();
        }
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
    }
}