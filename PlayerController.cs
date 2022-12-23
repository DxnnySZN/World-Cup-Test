using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// this script allows the user to control its player
// if the user collects a trophy, a notification sound will display
// if the user falls off the map, the user has to restart all over again despite having collected some trophies during the previous round
// if the user collects all five trophies, the user wins the game as a message pops up confirming
public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public AudioClip trophySound;
    public GameObject winText;
    float xInput;
    float zInput;
    public float moveSpeed;
    int trophyScore;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        // if the ball falls below the plane, the level will reset
        if(transform.position.y <= -5f){
            SceneManager.LoadScene(0);
        }
    }

    private void FixedUpdate(){
        rb.AddForce(xInput * moveSpeed, 0, zInput * moveSpeed);
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Trophy"){
            trophyScore++;
            other.gameObject.SetActive(false);
            GetComponent<AudioSource>().PlayOneShot(trophySound);
        }
        if(trophyScore == 5){
            winText.SetActive(true);
        }
    }
}