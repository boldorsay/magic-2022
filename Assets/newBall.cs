using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class newBall : MonoBehaviour
{
    public GameObject prefab;
            public InputAction button;
    private float valueEncoder;

    // Start is called before the first frame update
    void Start()
    {
button.Enable();

    }


 void Update()
    {

        // if(Input.GetMouseButtonDown(1))
        // {
        //     Instantiate(prefab, transform.position, transform.rotation);
        // }
    

    
    
if(button.WasPressedThisFrame()){
  Debug.Log("pressed");
//yield return new WaitForSeconds(5);



//GameObject ball = new GameObject();
    Instantiate(prefab,transform.position,transform.rotation,transform.parent);

}




    }
   
}
