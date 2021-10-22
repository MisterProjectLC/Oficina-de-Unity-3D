using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 velocity;
    int damage;

    float clock = 0f;
    float maxLifetime = 2f;

    public void Setup(Vector3 velocity, int damage)
    {
        this.velocity = velocity;
        transform.up = velocity.normalized;
        this.damage = damage;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;

        clock += Time.deltaTime;
        if (clock > maxLifetime)
            Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (other.GetComponent<Damageable>())
            other.GetComponent<Damageable>().Damage(damage);

        Destroy(gameObject);
    }
}

























/*
     Vector3 velocity;
    int damage;

    float clock = 0f;
    float maxLifetime = 2f;

    public void Setup(Vector3 velocity, int damage)
    {
        this.velocity = velocity;
        transform.up = velocity.normalized;
        this.damage = damage;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;

        clock += Time.deltaTime;
        if (clock > maxLifetime)
            Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        if (other.GetComponent<Damageable>())
            other.GetComponent<Damageable>().Damage(damage);

        Destroy(gameObject);
    }
*/
