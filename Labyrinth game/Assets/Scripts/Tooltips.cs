using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;




public class Tooltips : MonoBehaviour
{
    public Image toolTip;
    private bool mouse_over = false;
    private bool isHit = true;
    Ray ray;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        isHit = Physics.Raycast(ray, out hit);
        
       if (isHit && hit.collider.CompareTag(tag))
        {
            mouse_over = true;
            Debug.Log("Mouse enter");
        }

       else if (!isHit)
        {
            mouse_over = false;
            Debug.Log("Mouse exit");
        }

        if (mouse_over)
        {
            Debug.Log("Mouse Over");
        }
    }

  
}
