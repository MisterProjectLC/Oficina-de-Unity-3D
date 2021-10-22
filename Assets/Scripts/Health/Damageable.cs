using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField]
    Health health;

    [SerializeField]
    [Range(0f, 2f)]
    float DamageSensitivity = 1f;

    public void Damage(int damage)
    {
        health.Damage((int)Mathf.Floor(damage * DamageSensitivity));
    }
}



























































/*
[SerializeField]
Health health;

[SerializeField]
[Range(0f, 2f)]
float DamageSensitivity = 1f;

public void Damage(int damage)
{
    health.Damage((int)Mathf.Floor(damage * DamageSensitivity));
}
*/
