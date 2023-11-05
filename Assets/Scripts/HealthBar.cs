using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Transform bar;

    public void SetSize(float health, float damage){
        print($"{bar.localScale}");
        bar.localScale = new Vector3(health / 100, 1f);

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
