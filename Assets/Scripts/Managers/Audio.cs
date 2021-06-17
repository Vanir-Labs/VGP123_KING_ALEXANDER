using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Audio : MonoBehaviour
    {
        public AudioSource audioSource;

        void Start()
        {
              audioSource.Play();
//            audioSource.PlayOneShot(audioSource.clip, 5);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

