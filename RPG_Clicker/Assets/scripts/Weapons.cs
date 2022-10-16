using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Weapons : MonoBehaviour
{
    public GameObject weapon;    
    public int ChosenWeapon;
    [SerializeField] public Button Hummer;
    [SerializeField] public Button Sword;
    [SerializeField] public Button staff;
    //golem == 1
    //skeleton == 2
    //ogr == 3

    
    private void ChosenHummer()
    {        
        Hummer.image.color = Color.white;
        Sword.image.color = Color.gray;
        staff.image.color = Color.gray;
        Global.Instance.ChosenWeapon = 1;
    }
    private void ChosenSword()
    {
        Hummer.image.color = Color.gray;
        Sword.image.color = Color.white;
        staff.image.color = Color.gray;
        Global.Instance.ChosenWeapon = 2;
    }
    private void Chosenstaff()
    {
        Hummer.image.color = Color.gray;
        Sword.image.color = Color.gray;
        staff.image.color = Color.white;
        Global.Instance.ChosenWeapon = 3;
    }    
}
