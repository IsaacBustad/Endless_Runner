using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    // Vars
    [SerializeField] private Transform[] wheleTFs = null;
    [SerializeField] private Vector3 rotationDir = Vector3.zero;




    // Methods
    // fixed to update with physics
    private void FixedUpdate()
    {
        AnimateWheles();
    }
    public void AnimateWheles()
    {
        foreach (Transform t in wheleTFs)
        {
            t.Rotate(rotationDir);
        }
    }



}
