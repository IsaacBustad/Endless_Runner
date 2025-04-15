using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BodyHealth : MonoBehaviour
{
    // Vars
    [SerializeField] PlayerHealth healthBar = null;

    // Methods
    private void OnCollisionEnter(Collision collision)
    {
        DammageDealer nDD = collision.gameObject.GetComponent<DammageDealer>();
        if (nDD != null)
        {
            TakeDammage(nDD.Dammage);
        }
        
    }


    /*private void OnTriggerEnter(Collider other)
    {
        //other.attachedRigidbody.gameObject.doThigs();
    }*/


    public void TakeDammage(float aDam)
    {
        if (healthBar != null)
        {
            healthBar.TakeDammage(aDam);
        }
        //healthBar.TakeDammage(aDam);
    }
}
