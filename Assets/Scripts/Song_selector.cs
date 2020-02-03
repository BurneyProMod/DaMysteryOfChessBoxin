using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song_selector : MonoBehaviour {
    public AudioSource audioManager;
    public AudioSource fightmanager;
    public AudioClip first;
    public AudioClip second;
    public AudioClip third;
    public AudioClip fourth;
    public AudioClip fifth;
    public AudioClip sixth;
    public AudioClip seventh;
    public AudioClip eighth;
    private int lengthOfSong;
    private bool canPlay = true;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (canPlay)
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    lengthOfSong = 300;
                    audioManager.clip = first;
                    audioManager.Play();
                    canPlay = false;
                    StartCoroutine("PlayMoosic");
                    break;
                case 2:
                    lengthOfSong = 240;
                    audioManager.clip = second;
                    audioManager.Play();
                    canPlay = false;
                    StartCoroutine("PlayMoosic");
                    break;
                case 3:
                    lengthOfSong = 300;
                    audioManager.clip = third;
                    audioManager.Play();
                    canPlay = false;
                    StartCoroutine("PlayMoosic");
                    break;
                case 4:
                    lengthOfSong = 300;
                    audioManager.clip = fourth;
                    audioManager.Play();
                    canPlay = false;
                    StartCoroutine("PlayMoosic");
                    break;
                case 5:
                    lengthOfSong = 210;
                    audioManager.clip = fifth;
                    audioManager.Play();
                    canPlay = false;
                    StartCoroutine("PlayMoosic");
                    break;
                case 6:
                    lengthOfSong = 150;
                    audioManager.clip = sixth;
                    audioManager.Play();
                    canPlay = false;
                    StartCoroutine("PlayMoosic");
                    break;
                case 7:
                    lengthOfSong = 310;
                    audioManager.clip = seventh;
                    audioManager.Play();
                    canPlay = false;
                    StartCoroutine("PlayMoosic");
                    break;
                case 8:
                    lengthOfSong = 135;
                    audioManager.clip = eighth;
                    audioManager.Play();
                    canPlay = false;
                    StartCoroutine("PlayMoosic");
                    break;
                default:
                    break;
            }
        }
	}

    IEnumerator PlayMoosic()
    {
        yield return new WaitForSecondsRealtime(lengthOfSong);
        canPlay = true;
    }

}
