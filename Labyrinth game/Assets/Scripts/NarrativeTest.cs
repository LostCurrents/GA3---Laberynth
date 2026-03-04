using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryBranch : BasicCollider
{

    public string Question;
    public string Answer1;
    public string Answer2;

    public Text banswer1;
    public Text banswer2;
    public Text tquestion;

    private void OnEnable()
    {
        Debug.Log("story ENABLE " + name);
        banswer1.text = Answer1;
        banswer2.text = Answer2;
        tquestion.text = Question;


    }

    private void Awake()
    {
        Debug.Log("story AWAKE " + name);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("story START " + name);
    }

    // Update is called once per frame
    void Update()
    {

    }




    public override void HandleTriggerEnter(Transform otherTransform)
    {

        Debug.Log("Handle Enter " + transform.name + " " + otherTransform.name);

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);

        }


    }
    public override void HandleTriggerExit(Transform otherTransform)
    {

        Debug.Log("Handle Exit " + transform.name + " " + otherTransform.name);


    }
}
