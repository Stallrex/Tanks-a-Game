using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private AudioSource audioSource;
    public bool player1 = true;
    public float speed = 10;
    public Transform firePoint;
    public GameObject bulletPrefab;

    public AudioClip a;
    public AudioClip shoot;

    public float fireRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Fire), fireRate, fireRate);
        audioSource = GetComponent<AudioSource>();
    }
    void Fire(){
        Instantiate(bulletPrefab, firePoint.position, transform.rotation);
        audioSource.PlayOneShot(shoot);


    }

    // Update is called once per frame
    void Update()
    {
        var direction = new Vector3();

        if(player1){
            direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
        }
        else{

            direction.x = Input.GetAxis("Horizontal2");
        direction.z = Input.GetAxis("Vertical2");

        }
        

        transform.position += direction * speed * Time.deltaTime;


        if(direction != Vector3.zero){
            transform.forward = direction;


        }
        

    }
}
