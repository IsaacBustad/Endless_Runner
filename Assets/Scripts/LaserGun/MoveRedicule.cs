using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRedicule : MonoBehaviour
{
    // Vars
    [SerializeField] private Transform lazerGunTF = null;

    // localay added to Lazer Gun Pose
    [SerializeField] Vector3 upperBoundV3 = Vector3.zero;
    [SerializeField] Vector3 lowerBoundV3 = Vector3.zero;

    // Method
    private void KeepBetweenBounds()
    {
        Vector3 nPos = Vector3.zero;

        float posX = Mathf.Clamp(transform.localPosition.x, lowerBoundV3.x, upperBoundV3.x);
        float posY = Mathf.Clamp(transform.localPosition.y, lowerBoundV3.y, upperBoundV3.y);

        //V = lazerGunTF.position + (lazerGunTF.right * posX);
        transform.position = lazerGunTF.position + (lazerGunTF.up * posY) + (lazerGunTF.right * posX);
    }



}
