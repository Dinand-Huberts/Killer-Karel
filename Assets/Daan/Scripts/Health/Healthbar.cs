using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currentHealthBar;


    // Start is called before the first frame update
    private void Start()
    {
        totalhealthBar.fillAmount = playerHealth.currentHealth / 10;
    }

    // Update is called once per frame
    private void Update()
    {
      currentHealthBar.fillAmount = playerHealth.currentHealth / 10;  
    }
}
