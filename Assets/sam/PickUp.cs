using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

private Inventory inventory;
public GameObject itemButton;
public GameObject currentGun;
 public GameObject[] guns;
  public GameObject weaponHolder;


    
   private void Start()
    {
       
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

 void OnTriggerEnter2D(Collider2D other){
    if (other.CompareTag("Player"))
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if  (inventory.isFull[i] == false)
            {
                inventory.addGun(gameObject.name, i, itemButton);
                
                Destroy(gameObject);
                break;
            }
        }
    }
 }
 
}
