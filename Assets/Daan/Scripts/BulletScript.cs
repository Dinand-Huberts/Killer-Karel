using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            HealthE sn = collision.gameObject.GetComponent<HealthE>();
            sn.TakeDamageE(1);
            Debug.Log("test");
        }

        if (collision.gameObject.tag == "Player")
        {
            Health sn = FindObjectOfType<Health>();
            sn.TakeDamage(1);
            Debug.Log("test");
        }
        Debug.Log(gameObject.tag);
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
