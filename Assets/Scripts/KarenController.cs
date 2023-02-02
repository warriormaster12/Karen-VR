using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarenController : MonoBehaviour
{
    Animator animator;
    int throw_count = -1;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    bool AnimatorIsPlaying()
    {
        return animator.GetCurrentAnimatorStateInfo(0).length >
               animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }
    bool AnimatorIsPlaying(string stateName)
    {
        return AnimatorIsPlaying() && animator.GetCurrentAnimatorStateInfo(0).IsName(stateName);
    }

    // Update is called once per frame
    void Update()
    {
        AnimationClip[] clips = animator.runtimeAnimatorController.animationClips;
        if (throw_count == 4)
        {
            animator.SetBool("throwing", false);
            if (AnimatorIsPlaying("Angry"))
            {
                throw_count = -1;
                animator.SetBool("throwing", true);
            }
        }
        else
        {
            foreach (AnimationClip clip in clips)
            {
                switch (clip.name)
                {
                    case "Throw":
                        animator.SetBool("throwing", true);
                        if (AnimatorIsPlaying(clip.name))
                        {
                            throw_count++;
                        }
                        break;
                }
            }
        }
    }
}
