using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public Transform[] traget;
    public float speed;

    private int current;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(transform.position != traget[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, traget[current].position, speed * Time.deltaTime);
            GetComponent<Transform>().position = pos;

            Debug.Log("pos");

            // Get the Mesh of PlatonicShape and set it to the MeshCollider of the PlatonicShape C 

            
           // Update the meshCollider form the Mesh of the meshFilter
            GetComponentInChildren<MeshCollider>().sharedMesh = GetComponentInChildren<MeshFilter>().mesh; 
        }
        else
        {
            current = (current + 1) % traget.Length;
        }
    }
}
