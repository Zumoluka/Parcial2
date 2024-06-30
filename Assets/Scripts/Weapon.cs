using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponData weaponData; // referenciar al Scriptable Object

    void Start()
    {
        // usar de los datos del Scriptable Object
        Debug.Log("Weapon Name: " + weaponData.weaponName);
        Debug.Log("Weapon Damage: " + weaponData.damage);
        Debug.Log("Weapon Range: " + weaponData.range);
    }
}
