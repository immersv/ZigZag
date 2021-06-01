﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    Vector3 direction;// 
    public float playerSpeed;
    public GameObject particleEffectsPrefab;
    [SerializeField]
    int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (direction == Vector3.forward)
            {
                direction = Vector3.left;
               
            }
            else
            {
                direction = Vector3.forward;
                
            }
            score = score + 1;
            Debug.Log("Score: " + score);
        }

        transform.Translate(direction * playerSpeed * Time.deltaTime);
        
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            score = score + 5;//or score+=5
            Debug.Log("Score: " + score);

            other.gameObject.SetActive(false);
            Instantiate(particleEffectsPrefab, transform.position, Quaternion.identity);
        }
    }
}



/*Task 
 * Player Death logic
 * To Publish the score in UI
 * to create the end canvas animation
 * when player is dead make active the endscreen animation  and display score,Replay options
 */
