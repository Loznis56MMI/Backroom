using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShpere : MonoBehaviour
{

    [SerializeField] private int pv = 25;

    private bool active = true;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){
            Debug.Log("Joueur touché");
        }
    }
}
