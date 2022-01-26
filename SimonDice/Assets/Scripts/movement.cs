﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    AudioSource audioData;
    public AudioClip step1,step2;
    bool firstStep = true;
    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public bool moveForward;
    public float speed = 3.5f;
    private float gravity = 10f;

    private CharacterController characterController;

    // Use this for initialization
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
      PlayerMovement();
    }

    void PlayerMovement() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (horizontal != 0f || vertical != 0f)
        {
            if (!audioData.isPlaying) {
                if (firstStep)
                {
                    audioData.clip = step1;
                }else{
                    audioData.clip = step2;
                }
                firstStep = !firstStep;
                audioData.Play(0);
            }
            
        }
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speed;
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -=gravity;
        characterController.Move(velocity*Time.deltaTime);
    }
}