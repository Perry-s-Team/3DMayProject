using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : PlayerHealth
{
    [SerializeField] private Transform player;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text money;
    [SerializeField] private GameObject panel;
    [SerializeField] private PlayerHealth health;

    private void Start()
    {
        health = GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        if (player != null)
        scoreText.text = ((int)(player.position.z)).ToString();

        if (health.currentHealth <= 0)
        {
            //money.text = scoreText.text / 50;
            panel.SetActive(true);
        }
    }
}
