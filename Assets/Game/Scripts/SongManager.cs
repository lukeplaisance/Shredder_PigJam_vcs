using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using System.IO;
using UnityEngine.Networking;
using System;

public class SongManager : MonoBehaviour
{
    //the current position of the song (in seconds)
     public float songPosition;

    //the current position of the song (in beats)
    public float songPosInBeats;

    public float beatsShownInAdvance;

    //the duration of a beat
    public float secPerBeat;

    //how much time (in seconds) has passed since the song started
    public float dsptimesong;

    //beats per minute of a song
    public float bpm;

    //keep all the position-in-beats of notes in the song
    public float[] notes;

    //the index of the next note to be spawned
    public int nextIndex = 0;
    private Vector3 spawnPos;
    private Vector3 removePos;

    public GameObject notePrefab;
    private GameObject _noteInstance;
    public Vector3 SpawnPos => spawnPos;
    public Vector3 RemovePos => removePos;

    void Start()
    {
        //calculate how many seconds is one beat
        //we will see the declaration of bpm later
        secPerBeat = 60f / bpm;

        //record the time when the song starts
        dsptimesong = (float)AudioSettings.dspTime;

        //start the song
        GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        //calculate the position in seconds
        songPosition = (float)(AudioSettings.dspTime - dsptimesong - beatsShownInAdvance);

        //calculate the position in beats
        songPosInBeats = songPosition / secPerBeat;
        if (nextIndex < notes.Length && notes[nextIndex] < songPosInBeats + beatsShownInAdvance)
        {
          _noteInstance =  Instantiate( notePrefab );
            _noteInstance.transform.position = _noteInstance.GetComponent<Note>().spawnPos;
            _noteInstance.GetComponent<Note>().songPosInBeats = songPosInBeats;
            _noteInstance.GetComponent<Note>().beatsShownInAdvance = beatsShownInAdvance;

            //initialize the fields of the music note

            nextIndex++;
        }
    }

}
