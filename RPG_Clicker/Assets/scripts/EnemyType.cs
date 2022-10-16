using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class EnemyType : MonoBehaviour
{
    private int Enemy;
    [SerializeField] public GameObject Golem;
    [SerializeField] public GameObject Skeleton;
    [SerializeField] public GameObject Ogr;
    
    public void Enemytype()
    {
        Enemy = Random.Range(1, 4);
        Global.Instance.EnemyType = Enemy;
        if (Enemy == 1)
        {
            Golem.SetActive(true);
            Skeleton.SetActive(false);
            Ogr.SetActive(false);
        }
        if (Enemy == 2)
        {
            Golem.SetActive(false);
            Skeleton.SetActive(true);
            Ogr.SetActive(false);
        }
        if (Enemy == 3)
        {
            Golem.SetActive(false);
            Skeleton.SetActive(false);
            Ogr.SetActive(true);
        }           
    }
}
