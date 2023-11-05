using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject explosion;
    public float maxDamage = 4;
    public float minDamage = 1;

    public float speed = 20;
    public float lifeTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Explode), lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision other) {
        Health health = other.gameObject.GetComponent<Health>();
        if(health != null){

            var damage = Random.Range(minDamage, maxDamage + 1);
            health.TakeDamage(damage);

        }
        Explode();
    }

    void Explode(){
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);

    }
}
