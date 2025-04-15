using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.InputSystem;


[RequireComponent(typeof(LineRenderer))]
public class LaserGun : MonoBehaviour
{
    // Vars
    [SerializeField] private float dammage = 5f;
    private LineRenderer lineRenderer = null;
    [SerializeField] float fireRange = 10f;

    // movable objects for recording
    //[SerializeField] private Transform endPose



    // Methods
    private void OnEnable()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void FixedUpdate()
    {
        //UseLaser();
    }

    public void UseLaser()
    {
        Vector3 endPnt = Vector3.zero;

        RaycastHit hitInfo;

        // Physics.Raycast(transform.position, transform.forward, out hitInfo, 10f);

        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 10f))
        {
            endPnt = hitInfo.point;

            DrawLazer( hitInfo.point);
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }

    public void UseLaser( InputAction.CallbackContext aCon)
    {
        if (aCon.canceled == true)
        {
            lineRenderer.enabled = false;
        }
        else
        {
            Vector3 endPnt = Vector3.zero;

            RaycastHit hitInfo;

            // Physics.Raycast(transform.position, transform.forward, out hitInfo, 10f);

            if (Physics.Raycast(transform.position, transform.forward, out hitInfo, fireRange))
            {
                endPnt = hitInfo.point;

                DrawLazer(hitInfo.point);
            }

            else
            {
                Vector3 nPt = transform.position + (transform.forward * fireRange);
                DrawLazer(nPt);
            }

        }

        /*Vector3 endPnt = Vector3.zero;

        RaycastHit hitInfo;

        // Physics.Raycast(transform.position, transform.forward, out hitInfo, 10f);

        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 10f))
        {
            endPnt = hitInfo.point;

            DrawLazer(hitInfo.point);
        }*/
        
    }

    private void DrawLazer(Vector3 aPnt)
    {
        lineRenderer.enabled = true;
        List<Vector3> startStopPts = new List<Vector3>();
        startStopPts.Add(transform.position);
        startStopPts.Add(aPnt);

        lineRenderer.SetPositions(startStopPts.ToArray());
    }

    // Accessors



}
