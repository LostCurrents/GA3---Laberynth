using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryCollide : BasicCollider
{

    public GameObject ObjOfInterest;
    public GameObject Panel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnAnswer1()
    {
        Debug.Log("Answer 1 clickeed");

        if (ObjOfInterest.transform.childCount > 0)
        {
            ObjOfInterest.transform.GetChild(0).gameObject.SetActive(true);
            ObjOfInterest = ObjOfInterest.transform.GetChild(0).gameObject;
        }

    }

    public void OnAnswer2()
    {

        Debug.Log("Answer 2 clickeed");
        if (ObjOfInterest.transform.childCount > 0)
        {
            ObjOfInterest.transform.GetChild(1).gameObject.SetActive(true);
            ObjOfInterest = ObjOfInterest.transform.GetChild(1).gameObject;
        }

    }

    public override void HandleTriggerEnter(Transform otherTransform)
    {

        Debug.Log("Handle Enter " + transform.name + " " + otherTransform.name);

        ObjOfInterest.SetActive(true);
        Panel.SetActive(true);
    }
    public override void HandleTriggerExit(Transform otherTransform)
    {

        Debug.Log("Handle Exit " + transform.name + " " + otherTransform.name);

        ObjOfInterest.SetActive(false);
        Panel.SetActive(false);
    }
}