using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DectectCollision : MonoBehaviour
{
    // Start is called before the first frame update
  void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Collision");
        }
    }
}
