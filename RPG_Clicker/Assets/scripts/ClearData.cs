using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClearData : MonoBehaviour
{
    private readonly int PlayerDamage = 10;
    private readonly int MaxEnemyHp = 100;
    public void ClearAllData()
    {        
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("PlayerDamage", PlayerDamage);
        PlayerPrefs.SetInt("MaxEnemyHp", MaxEnemyHp);
    }
}
