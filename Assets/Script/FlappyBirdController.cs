using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FlappyBirdController: MonoBehaviour {
  public float flapPower;
  Rigidbody2D rb; //The rigidbody2D attached to flappybird
  // Use this for initialization
  void Start() {
    rb = GetComponent < Rigidbody2D > (); //Getting reference to
    flappybird 's RigidBody2D
  }
  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.Space)) //If spacebar is pressed down
    // Calls once when pressed down
    {
      rb.velocity = new Vector2(rb.velocity.x, flapPower); //Adds an
      upward velocity to the Rigidbody
    }
  }
}