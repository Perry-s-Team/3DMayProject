using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_Follow : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Transform player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed);
    }
}

