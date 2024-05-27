using UnityEngine;

public class CollisionZ : PlayerHealth
{
    [SerializeField] private int zombieDamage = 1;
    [SerializeField] private PlayerHealth health;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Animator _animator;



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
            _animator.SetBool("Death", true);
            _rb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
            Invoke(nameof(Destroyy), 3f);
        }
    }
    private void Damage()
    {
        health.currentHealth -= zombieDamage;
    }
    private void Destroyy()
    {
        Destroy(gameObject);
    }
}
