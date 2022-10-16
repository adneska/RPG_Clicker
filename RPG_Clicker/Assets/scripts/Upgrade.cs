using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    private int Coins;
    private int PlayerDamage;
    [SerializeField] private TMP_Text CoinsText;

    public void UpgradeCoast()
   {
        if (PlayerPrefs.HasKey("Coins"))
            Coins = PlayerPrefs.GetInt("Coins");
        if (PlayerPrefs.HasKey("PlayerDamage"))
            PlayerDamage = PlayerPrefs.GetInt("PlayerDamage");

        if (Coins < 500)
        {
            CoinsText.text = Coins.ToString();
        }
        else if (Coins > 500 && Coins < 2000)
        {
            PlayerDamage += 15;
            Coins -= 500;
            CoinsText.text = Coins.ToString();            
        }
        else if (Coins > 2000 && Coins < 4000)
        {
            PlayerDamage += 50;
            Coins -= 2000;
            CoinsText.text = Coins.ToString();
        }
        else if (Coins > 4000 && Coins < 10000)
        {
            PlayerDamage += 100;
            Coins -= 4000;
            CoinsText.text = Coins.ToString();
        }
        else if (Coins > 10000)
        {
            PlayerDamage += 200;
            Coins -= 10000;
            CoinsText.text = Coins.ToString();
        }
              
        PlayerPrefs.SetInt("PlayerDamage", PlayerDamage);
        PlayerPrefs.SetInt("Coins", Coins);
    }
}
