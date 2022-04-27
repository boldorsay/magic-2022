using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Formats.Alembic.Importer;

public class MainObjectFeedbackRotation : MonoBehaviour
{
    public InputAction encoder;
    Vector3 scaleVel;


    void Awake()
    {
        encoder.Enable();


    }

    void Update()
    {
         Debug.Log("pos");

            // Get the Mesh of PlatonicShape and set it to the MeshCollider of the PlatonicShape C 

            
           // Update the meshCollider form the Mesh of the meshFilter
    GetComponentInChildren<MeshCollider>().sharedMesh = GetComponentInChildren<MeshFilter>().mesh; 
        GetComponent<AlembicStreamPlayer>().CurrentTime = encoder.ReadValue<float>() * 100;
        // timePaul.GetComponent<AlembicStreamPlayer>().CurrentTime = encoder1.ReadValue<float>() * 10000;
        //transform.rotation = Quaternion.Euler(0,encoder1.ReadValue<float>()*10000,encoder2.ReadValue<float>()*10000);
        // Vector3 targetScale = Vector3.one * Mathf.Lerp(.1f,.2f, button.ReadValue<float>());
        // transform.localScale = Vector3.SmoothDamp(transform.localScale, targetScale, ref scaleVel, 0.2f);

    }
}

