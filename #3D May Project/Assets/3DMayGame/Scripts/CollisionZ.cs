using UnityEngine;

public class CollisionZ : PlayerHealth
{
    [SerializeField] private int zombieDamage = 1;
    [SerializeField] private PlayerHealth health;
    //[SerializeField] private 


    public void Start()
    {
        health = GetComponent<PlayerHealth> ();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
           health.currentHealth -= zombieDamage;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Invoke("Damage", 2f);
        }
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
