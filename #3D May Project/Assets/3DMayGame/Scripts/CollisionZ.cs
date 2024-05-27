using UnityEngine;

public class CollisionZ : PlayerHealth
{
    [SerializeField] private int zombieDamage = 1;
    [SerializeField] private PlayerHealth health;



    public void Start()
    {
        health = GetComponent<PlayerHealth> ();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {

            Damage();
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Invoke("Damage", 2f);
        }
        if (collision.gameObject.tag == "Bullet")
            Destroy(gameObject);
    }

    public void Update()
    {
        if(health.currentHealth <= 0)
        {
            Destroy(gameObject);        
        }
    }
    private void Damage()
    {
        health.currentHealth -= zombieDamage;
    }  
}
