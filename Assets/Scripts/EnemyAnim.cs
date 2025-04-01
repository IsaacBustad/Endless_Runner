using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class EnemyAnim : MonoBehaviour
{
    // Vars
    [SerializeField] private float animBlend = 0;
    [SerializeField] private Animator anim = null;

    // [SerializeField] private Animator anim;

    // Methods
    private void OnEnable()
    {
        AnimateEnemy();
    }
    public void AnimateEnemy()
    {
        anim.SetFloat("Blend", animBlend);
            //animator.SetFloat("Forward", v);
    }

    public void ChangeAnimBlens()
    {
        anim.SetFloat("Blend", animBlend);
    }

    // Accessor
    public float AnimBlend { set { if(value >=0 && value <= 2) animBlend = value; ChangeAnimBlens(); } }
}
