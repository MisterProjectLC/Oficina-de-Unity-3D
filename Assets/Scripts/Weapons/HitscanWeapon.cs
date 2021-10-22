using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitscanWeapon : Weapon
{
    [SerializeField]
    GameObject sparks;

    protected override void Fire()
    {
        RaycastHit info;
        Physics.Raycast(Mouth.position, Mouth.forward, out info);
        if (info.collider)
        {
            if (info.collider.GetComponent<Damageable>())
                info.collider.GetComponent<Damageable>().Damage(Damage);
            Instantiate(sparks, info.point, Quaternion.LookRotation(Vector3.ProjectOnPlane(Random.insideUnitSphere, info.normal), info.normal));
        }
    }
}

































































/*
[SerializeField]
GameObject sparks;

protected override void Fire()
{
    RaycastHit info;
    Physics.Raycast(Mouth.position, Mouth.forward, out info);
    if (info.collider)
    {
        if (info.collider.GetComponent<Damageable>())
            info.collider.GetComponent<Damageable>().Damage(Damage);
        Instantiate(sparks, info.point, Quaternion.LookRotation(Vector3.ProjectOnPlane(Random.insideUnitSphere, info.normal), info.normal));
    }
}
*/