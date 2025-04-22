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

    // particle Vars
    [SerializeField] private GameObject laserPS = null;

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
            lineRenderer.enabled = true;
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


                // sparks from laser
                laserPS.gameObject.SetActive(true);
                laserPS.transform.position = endPnt;
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
        // show line renderer
        lineRenderer.enabled = true;

        // create a list of V3s for Line renderer
        List<Vector3> startStopPts = new List<Vector3>();

        // add points it V3s
        startStopPts.Add(transform.position);
        startStopPts.Add(aPnt);

        // set points to draw
        lineRenderer.SetPositions(startStopPts.ToArray());
    }

    // Accessors



}
