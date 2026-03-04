using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class FloorAnimScript : MonoBehaviour
{
    public Animator anim;
    public StoryScript Story;
    public Narrative narration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string parm = narration.paramName;
        anim.SetTrigger(parm);
    }

    
}
