

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.Formats.Alembic.Importer;

public class rotationYTrompette : MonoBehaviour
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

        //     Get the Mesh of PlatonicShape and set it to the MeshCollider of the PlatonicShape C 

            
        //    Update the meshCollider form the Mesh of the meshFilter
        // Put a condition to check if encoder.readvalue is changed or not 

            // Debug.Log("cscsscsc");

      
            // GetComponentInChildren<MeshCollider>().sharedMesh = GetComponentInChildren<MeshFilter>().mesh; 
            // GetComponent<AlembicStreamPlayer>().CurrentTime = encoder.ReadValue<float>() * 100;
            // get the value of the encoder and add it on the blensh of the platonic shape 

            // GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, encoder.ReadValue<float>() * 100);
            // Debug.Log(GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(0));


            // var render = GetComponent<SkinnedMeshRenderer>();
            // render.SetBlendShapeWeight(0,100f);
            // Mesh bakeMesh = new Mesh();
            // render.BakeMesh(bakeMesh);
            // var collider = GetComponent<MeshCollider>();
            // collider.sharedMesh = bakeMesh;

            // Change the roatation of the object with the encoder value 
            transform.rotation = Quaternion.Euler( 180 , -90 , 20 + encoder.ReadValue<float>() * 100);



            // GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, encoder.ReadValue<float>() * 100);



            // GetComponent<AlembicStreamPlayer>().CurrentTime = encoder.ReadValue<float>() * 100;
                    //  Debug.Log(GetComponent<AlembicStreamPlayer>().CurrentTime);


        



    }
}
