using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CodeHand : MonoBehaviour
{
    public Animator animator;          // Référence à l'Animator

    public InTPuzzle ITP;          

    public GameObject Tab1;
    public GameObject Tab2;
    public GameObject TabAnime;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ActiverAnimations();
        }
    }

    void ActiverAnimations()
    {
        if(ITP.Pieces == 1){

            animator.SetBool("Have 1", true);
            print("Have 1");

        }else if ((ITP.Pieces == 2)){

            animator.SetBool("Have 2", true);

        }else if ((ITP.Pieces == 3)){

            animator.SetBool("Have 3", true);
            StartCoroutine(enumHand());

        }

    }


    IEnumerator enumHand(){

        yield return new WaitForSeconds(1f);
        animator.SetBool("FinalHand", true);

        yield return new WaitForSeconds(3.5f);
        Tab1.SetActive(false);
        Tab2.SetActive(true);


        yield return new WaitForSeconds(2f);
        TabAnime.SetActive(true);

    }
}
