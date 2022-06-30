using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
    


public class ShootScript : MonoBehaviour {

    public Transform Gun;

    public Animator gunAnimator;

    Vector2 direction;

    public GameObject Bullet;

    public float BulletSpeed;

    public Transform ShootPoint;

    public float fireRate;

    float ReadyForNextShot;

    public AudioClip gunFired1;
    public AudioClip gunFired2;
    public AudioClip gunFired3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       direction = mousePos - (Vector2)Gun.position; 
       FaceMouse();



       if (Input.GetMouseButton(0))
       {
           if(Time.time > ReadyForNextShot)
           {
               ReadyForNextShot = Time.time + 1/fireRate;
               shoot();
           }
       }
    }

    void FaceMouse()
    {
        Gun.transform.right = direction;
    }

    void shoot()
    {
        int randomSound = Random.Range(1, 3);
        string GunSound = "gunFired" + randomSound;

       /* AudioSource gunSoundAudio = GameObject.Find(GunSound);*/

        /*AudioSource audio = GetComponent<AudioSource>();

        audio.Play();*/
        GameObject BulletIns = Instantiate(Bullet,ShootPoint.position,ShootPoint.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);
        gunAnimator.SetTrigger("Shoot");
        Destroy(BulletIns,3);
    }
}
