using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigTableau : MonoBehaviour
{
    public InTPuzzle ITP;
    public GameObject Tb1;
    public GameObject Tb2;
   
    void Start()
    {
        Tb1.SetActive(true);
    }

   
    void Update()
    {
        
    }
        
        
    void OnTriggerEnter (Collider col)
    {
        if(col.CompareTag("Player") && ITP.Pieces == 1){
            print("EnterCol");
            Tb1.SetActive(false);
            Tb2.SetActive(true);
        }
    }
}
