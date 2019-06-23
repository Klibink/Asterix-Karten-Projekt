using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// StartCamera for AnimationBeginning, Trigger for BookOpening-Animation
public class LillyCam : MonoBehaviour
{
    private float Timer = 4.9f;
    public GameObject camstart;
    public GameObject camGame;
    public GameObject book;
    private Animator animatorcam;
    private Animator animatorbook;

    // Start is called before the first frame update
    void Start()
    {
        animatorcam = GetComponent<Animator>();
        animatorbook = book.GetComponent < Animator>();
        animatorcam.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            //Animate();
            animatorbook.SetBool("Open", true);
            //yield return new WaitForSeconds(animatorbook.GetCurrentAnimatorStateInfo(0).length + animatorbook.GetCurrentAnimatorStateInfo(0).normalizedTime);
            
        }
    }

   public void AnimationEnd(string message)
    {
        if (message.Equals("CamDone"))
        {
            camGame.SetActive(true);
            camstart.SetActive(false);
        }
    }
}
