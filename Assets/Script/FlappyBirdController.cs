using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FlappyBirdController : MonoBehaviour {

  public float flapPower;
  bool movementDisabled;
  Rigidbody2D rb; //The rigidbody2D attached to flappybird
  void Awake () { //happens before Start()
    movementDisabled = false;
    Kill.onKill += OnDeath; //subscribe our OnDeath function to the onKill event
  }
  // Use this for initialization
  void Start(){
    rb = GetComponent<Rigidbody2D>(); //Gets reference to flappybird's  RigidBody2D once the game starts
  }
  // Update is called once per frame
  void Update() {
    if (movementDisabled) return; //return from the update function if movement is disabled so we can't take input anymore
    if (Input.GetKeyDown(KeyCode.Space)){  //If spacebar is pressed down
      // Calls once when pressed down
      rb.velocity = new Vector2(rb.velocity.x, flapPower); //Adds an upward velocity to the Rigidbody
    }
  }
  void OnDeath() { //the onDeath event will trigger this function
    movementDisabled = true; 
    GetComponent<BoxCollider2D>().enabled = false; // We dont want flappybird to touch the AddScore box Collider when it dies
  }
  void OnDestroy(){
    Kill.onKill -= OnDeath; //Unsubscribe when gameobject is destroyed
  }
}