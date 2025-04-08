using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    // Vars
    [SerializeField] private Transform[] wheleTFs = null;
    [SerializeField] private Vector3 rotationDir = Vector3.zero;

    [SerializeField, Range(0, 90)] float maxBodTurn;
    [SerializeField] private Transform playerBody = null; 




    // Methods
    // fixed to update with physics
    private void FixedUpdate()
    {
        AnimateWheles();
    }

    public void AnimPlayerTurn()
    {

    }
    public void AnimateWheles()
    {
        foreach (Transform t in wheleTFs)
        {
            t.Rotate(rotationDir);
        }
    }



}
