using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PipeSpawner : MonoBehaviour {
    public GameObject pipePrefab; //Our pipe prefab from the prefab folder
    public float moveSpeed; //speed of our pipe
    public float spawnDelay; //The delay between each pipe spawn

    // Use this for initialization
    void Start(){
        StartSpawn(); //We will start the spawn when game starts
    }
    public void StartSpawn(){
        StartCoroutine("StartSpawnCo"); // Starts the spawn coroutine
    }
    public void StopSpawn(){
        StopCoroutine("StartSpawnCo"); // Stops the spawn coroutine
    }
    IEnumerator StartSpawnCo(){ //Spawn pipe and set it's RigidBody2D's velocity
        while (true){
        GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        //The gameobject you want to spawn
        //The Vector3 position you spawning it at, the gameobject's position that this script is attached to
        //The rotation you want, in this case it means "no ratation"
        pipe.GetComponent<Rigidbody2D>().velocity = Vector2.left*moveSpeed;
        // First you want to grab reference to the pipe's RigidBody2D,
        // then you set it's velocity in the direction of left and moveSpeed
        yield return new WaitForSeconds(spawnDelay); //All coroutines
        // must yield return at the end, especially in a while loop or else game will crash
        //In this case we will yield return a wait for our spawn delay
        }
    }
}