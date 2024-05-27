using DefaultNameSpace;
using UnityEngine;
using UnityEngine.UI;

public class ClosestZondbe : WlalkPlayer
{
    public string enemyTag = "Enemy";
    static public WlalkPlayer coins;

    private void Update()
    {
        coins = GetComponent<WlalkPlayer>();
        if (Input.GetMouseButtonDown(0)) // Проверяем, была ли нажата левая кнопка мыши
        {
            GameObject closestEnemy = FindClosestEnemy(); // Находим ближайшего врага

            if (closestEnemy != null && ammoText.text > 0)
            {
                ammunition -= 1;
                // Убиваем ближайшего врага
                Destroy(closestEnemy);
            }
        }
    }

    GameObject FindClosestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag); // Находим всех врагов с тегом "enemy"

        GameObject closestEnemy = null;
        float closestDistance = Mathf.Infinity;
        Vector3 position = transform.position;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(position, enemy.transform.position);

            if (distance < closestDistance)
            {
                closestEnemy = enemy;
                closestDistance = distance;
            }
        }

        return closestEnemy;
    }
}
