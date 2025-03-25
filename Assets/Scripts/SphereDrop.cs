using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDrop : MonoBehaviour
{
    // Var
    [SerializeField] private Rigidbody rb = null;
    [SerializeField] private Color nColor = Color.white;

    private void Awake()
    {
        if (nColor != Color.white)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = nColor;
        }
        

        rb.useGravity = true;
        rb.freezeRotation = true;
        
    }


}
