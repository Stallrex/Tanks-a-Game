using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{

    private float maxHealth = 100f;
    private float hp;

    public UnityEvent<float, float> onDamage;
    public UnityEvent onDeath;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(float damage){

        hp -= damage;
        hp = hp < 0 ? 0 : hp;
        onDamage.Invoke(hp, damage);
        if(hp <=0){
           onDeath.Invoke();
           Destroy(this);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
