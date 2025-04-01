

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // vars
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private MeshRenderer meshRenderer = null;

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


        meshRenderer.material.mainTextureOffset -= new Vector2(0, moveSpeed * Time.deltaTime);

    }



    // Accessors
}
