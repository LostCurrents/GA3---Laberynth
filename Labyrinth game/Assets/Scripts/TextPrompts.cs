using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TextPrompts : MonoBehaviour
{
    public Button[] button;
    public StoryCollider trigger;
    public Transform first;
    public Text body;
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
       

        button[0].gameObject.SetActive(true);

        Text text = button[0].GetComponentInChildren<Text>();

        string narrate = (first.GetComponent<Narrative>().MainText);
        text.text = narrate;

        //For Attempt at Narration Box seperate from buttons
        body.gameObject.SetActive(true);


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

    public void OnClick(int NodeNum)
    {
        trigger.StoryTrigger.SetActive(false);
        trigger.Panel.SetActive(false);
    }
}
