using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public float Health { get; set; }
    
    public float MaxHealth { get; set; }
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hurt(float damage, string cause)
    {
        Health -= damage;
    }
}
