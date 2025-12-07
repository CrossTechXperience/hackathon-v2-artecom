using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActiveAsk : MonoBehaviour
{
    public bool PostITActive = false;
    public Animator animO;
    public Animator animPress;

    void Start()
    {
        print("tamère");
    }
    void Update()
    {
       AskPostIt();
        
    }
    void AskPostIt(){

        if (Input.GetKeyDown(KeyCode.Q)) // Qwerty
        {
            print("Post-it");
            if (PostITActive)
            {
                // Ouvrir le menu
                print("PostIT ouvert");
                PostITActive = false;
                animO.SetBool("PostGo", true);
                animPress.SetBool("PressTouch", true);
                
                StartCoroutine(enumPress());
            }
            else
            {
                // Fermer le menu
                print("PostIT fermé");
                PostITActive = true;
                animO.SetBool("PostGo", false);
                animPress.SetBool("PressTouch", true);
                StartCoroutine(enumPress());
                
            }
        }

    }

    IEnumerator enumPress(){

        print("enumPlay");
        yield return new WaitForSeconds(0.5f);
        animPress.SetBool("PressTouch", false);
    }
}
