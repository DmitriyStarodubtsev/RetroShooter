using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthAmmount = 25;

    void Start()
    {       
    }
    void Update()
    {        
    }
   private  void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            PlayerController.instance.AddHealth(healthAmmount);

            AudioController.instance.PlayHealthPickup();
     
            Destroy(gameObject);
        }
    }
}
