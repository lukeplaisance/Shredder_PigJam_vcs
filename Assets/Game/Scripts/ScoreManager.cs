using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public UnityEvent<float> _addToScore;
    public UnityEvent<float> _removeFromScore;
}
