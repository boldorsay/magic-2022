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

    private float valueEncoder;


    void Awake()
    {
        encoder.Enable();
        valueEncoder = encoder.ReadValue<float>();


    }

    void Update()
    {

            // Get the Mesh of PlatonicShape and set it to the MeshCollider of the PlatonicShape C 

            
           // Update the meshCollider form the Mesh of the meshFilter
        // Put a condition to check if encoder.readvalue is changed or not 


        if (valueEncoder != encoder.ReadValue<float>())
        {

            GetComponentInChildren<MeshCollider>().sharedMesh = GetComponentInChildren<MeshFilter>().mesh; 
            GetComponent<AlembicStreamPlayer>().CurrentTime = encoder.ReadValue<float>() * 100;
                     Debug.Log(GetComponent<AlembicStreamPlayer>().CurrentTime);

            valueEncoder = encoder.ReadValue<float>();

        }



    }
}

