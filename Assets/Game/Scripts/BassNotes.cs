using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BassNotes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float[] bassNotesBars1To8 = { 1f, 1.5f, 2, 2.5f, 3.5f, 4f, 4.5f, 9, 9.5f, 10, 10.5f, 11.5f, 12, 12.5f,14.5f,15,16,16.5f,17,17.5f,18,18.5f,19.5f,20,20.5f,25,25.5f,26,26.5f,27.5f,28,28.5f,30,30.5f,31,31.5f,32 };

        //add 32 to these values
        float[] bassNotesBars9To16 = { 1f, 1.5f, 2, 2.5f, 3.5f, 4f, 4.5f, 9, 9.5f, 10, 10.5f, 11.5f, 12, 12.5f, 14.5f, 15, 16, 16.5f, 17, 17.5f, 18, 18.5f, 19.5f, 20, 20.5f, 25, 25.5f, 26, 26.5f, 27.5f, 28, 28.5f, 29, 29.5f, 30, 30.5f, 31, 31.5f,32,32.5f };

        //add 64 to these values
        float[] pianoNotesBars17To24 = {1,2.5f,6.5f,9,10.5f,17,18.5f,21,21.5f,22,22.5f,23,24,24.5f,29.5f,31};

        //add 96 to these values
        float[] pianoNotesBars25To32 = { 1, 2.5f, 4.5f, 6, 9, 10.5f, 12.5f, 14, 17, 18, 19.5f, 20.5f, 22.5f, 23, 23.5f, 24, 25, 26, 27.5f, 28.5f, 30.5f, 31, 31.5f, 32 };

        //add 128 to these values
        float[] guitarNotesBars33To40 = {1,5.5F,6,6.5f,7,9,10,10.5f,13.5f,14,14.5f,17.5f,18,18.5f,19,19.5f,20.5f,21.5f,22,22.5f,26,26.5f,28,28.5f,30,30.5f,32  };

        //add 160 to these values
        float[] guitarNotesBars41to48 = {1,7,8,8.5f,9,10,10.5f,11.5f,12,13,13.5f,14,14.5f,15,15.5f,16,16.5f,17,18,18.5f,19,20,20.5f,25,26.6f,28};

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
