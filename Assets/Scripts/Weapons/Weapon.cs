using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]
    protected Transform Mouth;

    [SerializeField]
    protected int Damage = 1;

    [SerializeField]
    float FireCooldown = 0.5f;
    float clock = 0f;

    private void Update()
    {
        if (clock > 0f)
            clock -= Time.deltaTime;
    }

    public void Trigger()
    {
        if (clock > 0f)
            return;
        clock = FireCooldown;

        Fire();
    }

    protected abstract void Fire();
}












































/*
[SerializeField]
    protected Transform Mouth;

    [SerializeField]
    protected int Damage = 1;

    [SerializeField]
    float FireCooldown = 0.5f;
    float clock = 0f;

    private void Update()
    {
        if (clock > 0f)
            clock -= Time.deltaTime;
    }

    public void Trigger()
    {
        if (clock > 0f)
            return;
        clock = FireCooldown;

        Fire();
    }

    protected abstract void Fire();
*/