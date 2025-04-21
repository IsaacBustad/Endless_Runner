using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    // Var
    // speed the enemy will move at
    [SerializeField] private float moveSpeed = 5f;
    // Rb for velocity refferenc
    private Rigidbody rb = null;

    // Methods
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        if (rb != null)
        {
            rb.velocity = transform.forward * moveSpeed;
        }
    }
}
