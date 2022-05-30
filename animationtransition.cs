using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationtransition : MonoBehaviour
{
    // Start is called before the first frame update
    public AnimationClip close;
    Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.clip = close;
            this.GetComponent<Animation>().Play("closef");
        }
    }
}
