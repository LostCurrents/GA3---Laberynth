using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasicCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Debug.Log("player hit " + name);

            //call the concrete implementation
            HandleTriggerEnter(other.transform);

          

         


        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {

            Debug.Log("player exit " + name);

            //call the concrete implementation
            HandleTriggerExit(other.transform);


        }

    }

    public abstract void HandleTriggerEnter(Transform otherTransform);
    public abstract void HandleTriggerExit(Transform otherTransform);
}
