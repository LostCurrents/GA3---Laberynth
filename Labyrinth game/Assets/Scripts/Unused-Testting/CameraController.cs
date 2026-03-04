using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float distance = 5.5f;
    public float height = 3.5f;
    public float rotateSpeed = 1.0f;
    private bool isMouseDown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - target.forward * distance + target.up * height;


        transform.LookAt(target);

        float turn = rotateSpeed * Input.GetAxis("Mouse X");

        if (Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
        }

        if (Input.GetMouseButtonUp((0)))
        {
            isMouseDown = false;
        }

        if (isMouseDown)
        {
            transform.Rotate(Vector3.up, turn, 0);
        }
    }
}
