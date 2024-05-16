using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionZ : PlayerHealth
{
    [SerializeField] private int zombieAttack = 1;
    [SerializeField] private PlayerHealth health;
    //[SerializeField] private 

    private void Start()
    {
        health = GetComponent<PlayerHealth> ();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           health.currentHealth -= zombieAttack;
        }
    }
    private void Update()
    {
        if(health.currentHealth <= 0)
        {
            //Destroy;
        }
    }
}
