

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // vars
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] MeshRenderer meshRenderer = null;

    private bool isLooping = false;


    // Methods
    #region Unity called Methods
    private void OnEnable()
    {
        CollectVars();
    }

    private void Update()
    {
        if (isLooping.Equals(true))
        {
            LoopTexture();
        }
    }
    #endregion


    private void CollectVars()
    {
        isLooping = true;
    }

    private void LoopTexture()
    {
        /*Vector2 curOff = meshRenderer.material.GetTextureOffset("PlaneMaterial 1");
        curOff.y += moveSpeed;
        meshRenderer.material.SetTextureOffset("PlaneMaterial 1", curOff);*/



        Vector2 curOff = meshRenderer.material.mainTextureOffset;
        curOff.y += moveSpeed;
        meshRenderer.material.mainTextureOffset = curOff;

    }



    // Accessors
}
