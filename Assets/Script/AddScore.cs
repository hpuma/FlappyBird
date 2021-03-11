using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AddScore : MonoBehaviour {
    void OnTriggerEnter2D (Collider2D col){
        if (col.tag == "Player" ){
        Score.instance.AddScore(1);
        }
    }
}