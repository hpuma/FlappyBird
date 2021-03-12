using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameOver : MonoBehaviour {
  public GameObject gameOver; //the GameOver gameobject under the Canvas gameobject

  void Awake (){
    Kill.onKill += OnGameOver; //Subscibes OnGameOver to the onKill event
  }
  void OnGameOver (){
    gameOver.SetActive( true ); // sets the active state of the gameOver panel to true
  }
  void OnDestroy (){
    Kill.onKill -= OnGameOver; //Unsubscribe when gameobject is destroyed
  }
}