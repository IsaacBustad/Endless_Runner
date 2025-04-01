using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Rigidbody))]
//[CreateAssetMenu]
public class PlayerMovement : MonoBehaviour
{
    // Vars
    private Vector3 movDir = Vector3.zero;

    [SerializeField, Tooltip("this gives you space to explain your code ")] private float maxSpeed = 25;

    [SerializeField] private float acceleration = 50;

    private Rigidbody rb;


    // Methods
    #region Unity Built Ins
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    #endregion



    public void GetMoveInput(InputAction.CallbackContext aCon) 
    {
        Vector2 rMovDir = aCon.ReadValue<Vector2>();

        Vector3 nMovDir = new Vector3( rMovDir.x, 0, rMovDir.y);

        movDir = nMovDir;
    
    }

    // apply Movement side to side
    private void MovePlayer()
    {
        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(movDir * acceleration, ForceMode.Force);
        }
        
    }





}
