using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosestShoot : MonoBehaviour
{

    GameObject closest;
    public List<GameObject> enemy;


    public string nearist;

    private void Start()
    {
        enemy = new List<GameObject>(GameObject.FindGameObjectsWithTag("Enemy"));
    }
    GameObject FindClosestEnemy()
    {
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in enemy)
        {
            Vector3 diff = go.transform.position - position;
            float curDiatance = diff.sqrMagnitude;
            if (curDiatance < distance)
            {
                closest = go;
                distance = curDiatance;
            }
        }
        return closest;
    }

}
