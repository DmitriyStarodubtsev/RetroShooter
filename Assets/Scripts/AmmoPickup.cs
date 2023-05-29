using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public int ammoAmmount = 25;

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
            PlayerController.instance.currentAmmo += ammoAmmount;
            PlayerController.instance.UpdateAmmouUI();

            AudioController.instance.PlayAmmoPickup();
            
            Destroy(gameObject);
        }
    }
}
