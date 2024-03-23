using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompuertaController : MonoBehaviour
{

    Animator animator;
    AudioSource audioSource;

    [SerializeField]

    AudioClip openSound, CloseSound;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Open()
    {
        animator.SetTrigger("open");
        audioSource.PlayOneShot(openSound);
    }

    public void Close()
    {
        animator.SetTrigger("close");
        audioSource.PlayOneShot(CloseSound);
    }


}
