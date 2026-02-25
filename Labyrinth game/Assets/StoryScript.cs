using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour
{
   public Button[] button;

    public int depth = 0;
    public Transform first;

    // Start is called before the first frame update
    void Start()
    {
        hideButtons();

        first = transform.GetChild(0);

        button[0].gameObject.SetActive(true);

        Text text = button[0].GetComponentInChildren<Text>();
        
        string narrate = (first.GetComponent<Narrative>().narration);
        text.text = narrate;

        //Finds assigned children and adds from narrative box
        int ct = first.childCount;
        for (int i = 0; i < ct; i++)
        {
            button[i+1].gameObject.SetActive(true);
            Text text2 = button[i + 1].GetComponentInChildren<Text>();

            //Gets the part with narrative script and coverts to string
            string narrate2 = (first.GetChild(i).GetComponent<Narrative>().narration);
            //Sets the text on button with above string
            text2.text = narrate2;
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
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
        
        hideButtons();
        first = first.GetChild(nodeNum);

        //If no more children, then exit current branch
        if(first.childCount == 0)
        {
            //move onto next part of Story
            depth++;
            first = transform.GetChild(depth);
        }

        button[0].gameObject.SetActive(true);

        Text text = button[0].GetComponentInChildren<Text>();

        string narrate = (first.GetComponent<Narrative>().narration);
        text.text = narrate;

        int ct = first.childCount;
        for (int i = 0; i < ct; i++)
        {
            button[i + 1].gameObject.SetActive(true);
            Text text2 = button[i + 1].GetComponentInChildren<Text>();


            string narrate2 = (first.GetChild(i).GetComponent<Narrative>().narration);
            text2.text = narrate2;
        }
    }

}
