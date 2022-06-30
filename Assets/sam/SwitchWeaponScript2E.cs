using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeaponScript2E : MonoBehaviour
{
public bool[] isFull;
    public GameObject[] slots;
    public GameObject[] guns;
    
    private string temp;
    



    public void switchGun(string gunName, int i, GameObject itemButton){
       
        isFull[i] = true;
        switch (gunName)
        {
           case "AK_pu":
            temp = "AK";
           break;
           case "M4_pu":
            temp = "M4";
           break; 
           
        }

        


        Instantiate(itemButton, slots[i].transform, false);
    }
    }



