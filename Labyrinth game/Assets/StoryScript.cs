using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour
{
    public Button[] button;
    public Text Body;
    public int depth = 0;
    public Transform first;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        anim = GetComponent<Animator>();

        //calls event to hide buttons not in current use
        hideButtons();

        first = transform.GetChild(depth);

        button[0].gameObject.SetActive(true);

        Text text = button[0].GetComponentInChildren<Text>();

        string narrate = (first.GetComponent<Narrative>().MainText);
        text.text = narrate;

        //For Attempt at Narration Box seperate from buttons
        Body.gameObject.SetActive(true);
        

        //Finds assigned children and adds from narrative box
        int ct = first.childCount;
        for (int i = 0; i < ct; i++)
        {
            // +1 as button 0 is always the question
            button[i + 1].gameObject.SetActive(true);
            Text text2 = button[i + 1].GetComponentInChildren<Text>();

            //Gets the part with narrative script and coverts to string
            string narrate2 = (first.GetChild(i).GetComponent<Narrative>().narration);
            //Sets the text on button with above string
            text2.text = narrate2;
            
        }

       
    }

    public void hideButtons()
    {
        for (int i = 0; i < button.Length; i++)
        {
            button[i].gameObject.SetActive(false);
        }
    }

    public void OnClick(int nodeNum)
    {
        Debug.Log("clicked" + nodeNum + " " + first.name);
        
        //Calls to hide prev button
        hideButtons();
        first = first.GetChild(nodeNum);

        //check parameter name set by Narrative Script
        string parm = first.GetComponent<Narrative>().paramName;
        anim.SetTrigger(parm);

        //If no more children, then exit current branch
        if(first.childCount == 0)
        {
            //move onto next part of Story
            depth++;
            first = transform.GetChild(depth);
            button[0].gameObject.SetActive(true);

           
        }

         //Check if hiding this will fix the problem of answer replacing question *update* no more need to hide

         button[0].gameObject.SetActive(true);

         Text text = button[0].GetComponentInChildren<Text>();

         string narrate = (first.GetComponent<Narrative>().MainText);
         text.text = narrate;

        int ct = first.childCount;
        for (int i = 0; i < ct; i++)
        {
            button[i + 1].gameObject.SetActive(true);
            Text text2 = button[i + 1].GetComponentInChildren<Text>();


            string narrate2 = (first.GetChild(i).GetComponent<Narrative>().narration);
            text2.text = narrate2;

            first.GetChild(i).GetComponent<Narrative>().StoryTrigger.gameObject.SetActive(true);
        }
    }

}
