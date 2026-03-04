using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryCollider : BasicCollider
{ 
    public GameObject StoryTrigger;
    public GameObject Panel;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void HandleTriggerEnter(Transform otherTransform)
    {

        Debug.Log("Handle Enter " + transform.name + " " + otherTransform.name);

        StoryTrigger.SetActive(true);
        Panel.SetActive(true);
    }
    public override void HandleTriggerExit(Transform otherTransform)
    {

        Debug.Log("Handle Exit " + transform.name + " " + otherTransform.name);

        StoryTrigger.SetActive(false);
        Panel.SetActive(false);
    }

    public void HidePanel ()
    {
        Panel.SetActive(false);
    }

}
