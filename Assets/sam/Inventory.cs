using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public bool[] isFull;
    public GameObject[] slots;
    public GameObject[] guns;
    public GameObject[] equipedGuns;
    private string temp;


   
    public void addGun(string gunName, int i, GameObject itemButton){
       
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

        foreach(GameObject go in guns)
 {
    
     if(go.name == temp)
     {
        equipedGuns[i] = go; 
        

     }
 }



        Instantiate(itemButton, slots[i].transform, false);
    }

    

}






   

