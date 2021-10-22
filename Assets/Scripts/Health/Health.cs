using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    int MaxHealth = 5;
    int CurrentHealth;

    bool dead = false;

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }


    public void Damage(int damage)
    {
        if (dead)
            return;

        CurrentHealth -= damage;

        if (CurrentHealth <= 0)
        {
            dead = true;
            CurrentHealth = 0;
        }
    }

    public void Heal(int heal)
    {
        if (dead)
            return;

        CurrentHealth += heal;
        if (CurrentHealth > MaxHealth)
            CurrentHealth = MaxHealth;
    }


    public int GetCurrentHealth()
    {
        return CurrentHealth;
    }

    public int GetMaxHealth()
    {
        return MaxHealth;
    }
}












































/*
    public UnityAction OnDamage;
    public UnityAction OnDeath;

 */