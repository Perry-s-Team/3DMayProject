using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text money;
    [SerializeField] private GameObject canvas;


    private void Update()
    {
        if (player != null)
        scoreText.text = ((int)(player.position.z)).ToString();

        if(player == null)
        {
            print("Player = null");
            money.text = scoreText.text;
            canvas.SetActive(true);
        }
    }
}
