using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public int Coins;    
    public int EnemyHp = 100;    
    public int Enemytype;    
    public int MaxEnemyHp;
    public int PlayerDamage;
    public int ChosenWeapon;
    public hpbar hpbar;    
    public Weapons GolemResist;
    public Weapons SkeletonResist;
    public Weapons OgrResist;
    public EnemyType EnemyType;
    [SerializeField] private TMP_Text CoinsText;

    void Start()
    {
        Coins = Global.Instance.Coins;
        MaxEnemyHp = Global.Instance.MaxEnemyHp;
        EnemyHp = MaxEnemyHp;
        hpbar.SetMaxHP(MaxEnemyHp);
        CoinsText.text = Coins.ToString();        
        EnemyType.Enemytype();
    }
    public void EnemyKill()
    {
        ChosenWeapon = Global.Instance.ChosenWeapon;
        PlayerDamage = Global.Instance.PlayerDamage;
        Enemytype = Global.Instance.EnemyType;

        if (EnemyHp > 0)
        {
            if (Enemytype == 1)
            {           
                if (ChosenWeapon == 1)
                    EnemyHp -= PlayerDamage / 2;
                else if (ChosenWeapon == 2)
                    EnemyHp -= PlayerDamage;
                else if (ChosenWeapon == 3)
                    EnemyHp -= PlayerDamage * 2;

                hpbar.SetHP(EnemyHp);
            }
            else if (Enemytype == 2)
            {
                if (ChosenWeapon == 1)
                    EnemyHp -= PlayerDamage * 2;
                else if (ChosenWeapon == 2)
                    EnemyHp -= PlayerDamage / 2;
                else if (ChosenWeapon == 3)
                    EnemyHp -= PlayerDamage;

                hpbar.SetHP(EnemyHp);
            }
            else if (Enemytype == 3)
            {
                if (ChosenWeapon == 1)
                    EnemyHp -= PlayerDamage;
                else if (ChosenWeapon == 2)
                    EnemyHp -= PlayerDamage * 2;
                else if (ChosenWeapon == 3)
                    EnemyHp -= PlayerDamage / 2;

                hpbar.SetHP(EnemyHp);
            }
            
        }
        else
        {
            MaxEnemyHp += PlayerDamage * 2;
            EnemyHp = MaxEnemyHp;
            hpbar.SetMaxHP(MaxEnemyHp);            
            Coins += EnemyHp / 20;
            CoinsText.text = Coins.ToString();
            Global.Instance.MaxEnemyHp = MaxEnemyHp;
            Global.Instance.Coins = Coins;
            EnemyType.Enemytype();
            PlayerPrefs.SetInt("Coins", Coins);
            PlayerPrefs.SetInt("MaxEnemyHp", MaxEnemyHp);
            PlayerPrefs.SetInt("PlayerDamage", PlayerDamage);
        }
    }
}
