using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class DammageDealer : MonoBehaviour
{
    // Vars
    [SerializeField] private float dammage = 1;



    // Methods
    /*private void OnCollisionEnter(Collision collision)
    {
        
    }*/

    // Accessor
    public float Dammage { get { return dammage; }  }


}
