using UnityEngine;

public class ProjectileWeapon : Weapon
{
    [SerializeField]
    GameObject bullet;

    [SerializeField]
    protected float BulletVelocity = 10f;

    protected override void Fire()
    {
        GameObject newInstance = Instantiate(bullet, Mouth.position, Quaternion.identity);
        newInstance.GetComponent<Bullet>().Setup(Mouth.forward * BulletVelocity, Damage);
    }
}































/*
[SerializeField]
    GameObject bullet;

    [SerializeField]
    protected float BulletVelocity = 10f;

    protected override void Fire()
    {
        GameObject newInstance = Instantiate(bullet, Mouth.position, Quaternion.identity);
        newInstance.GetComponent<Bullet>().Setup(Mouth.forward * BulletVelocity, Damage);
    }
*/
