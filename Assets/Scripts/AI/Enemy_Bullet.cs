using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet : MonoBehaviour
{

    public float dieTime, damage;
    public GameObject diePEFFECt;

    void Start()
    {
        StartCoroutine(CountDownTimer());
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
    }

    IEnumerator CountDownTimer()
    {
        yield return new WaitForSeconds(dieTime);

        Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
