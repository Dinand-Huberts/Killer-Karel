using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthE : MonoBehaviour
{

    [SerializeField] private float startingHealthE;
    public float currentHealthE { get; private set; }   
    private Animator animE;
    private bool deadE;

    private void Awake()
    {
        currentHealthE = startingHealthE;
        animE = GetComponent<Animator>();
    }

    public void TakeDamageE(float _damageE)
    {
        currentHealthE = Mathf.Clamp(currentHealthE - _damageE, 0, startingHealthE);

        if (currentHealthE > 0)
        {
            animE.SetTrigger("hurt");
        }
        else
        {
            if (currentHealthE <= 0)
            {
                // anim.SetTrigger("die");
                // GetComponent<PlayerMovement>().enabled = false;
                // GetComponent<ShootScript>().enabled = false;
                // GetComponent<SwitchWeaponScript>().enabled = false;
                Destroy(gameObject);

                // deadE = true;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
    
    }

    public void AddHealth(float _valueE)
    {
        currentHealthE = Mathf.Clamp(currentHealthE + _valueE, 0, startingHealthE);
    }


    // public void Die()
    // {
    //     SceneManager.LoadScene("DaanScene");
    // }
}
