using UnityEngine;

public class TriggerPieces : MonoBehaviour
{
    public InTPuzzle ITP;
    public GameObject CheckMarker;
    void Start()
    {
        CheckMarker.SetActive(false);
    }

    //void Update(){}

    void OnTriggerEnter (Collider col){

        if(col.CompareTag("Player")){
            print("EnterCol");
            ITP.Pieces += 1;
            Destroy(gameObject);
            //CheckMarker.SetActive(true);
        }

    }
}
