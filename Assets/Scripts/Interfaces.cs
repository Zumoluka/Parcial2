using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    int Health { get; set; }
    void TakeDamage(int amount);
    void Heal(int amount);
}