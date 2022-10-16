using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public static Global Instance { get; private set; }
    public int ChosenWeapon = 1;
    public int EnemyType = 1;
    public int Coins = 10;    
    public int MaxEnemyHp = 100;    
    public int PlayerDamage = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
            Instance = this;
        if (PlayerPrefs.HasKey("Coins"))
            Coins = PlayerPrefs.GetInt("Coins");
        if (PlayerPrefs.HasKey("MaxEnemyHp"))
            MaxEnemyHp = PlayerPrefs.GetInt("MaxEnemyHp");
        if (PlayerPrefs.HasKey("PlayerDamage"))
            PlayerDamage = PlayerPrefs.GetInt("PlayerDamage");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
