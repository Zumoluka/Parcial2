using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponData", menuName = "Weapon Data", order = 51)]
public class WeaponData : ScriptableObject
{
    public string weaponName; // Nombre del arma
    public int damage;        // Daño del arma
    public float range;       // Rango del arma
}
