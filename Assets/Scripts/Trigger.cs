using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger : MonoBehaviour
{

    public PlayableDirector playableDirector;
    public bool StayActive;

    private void OnTriggerEnter(Collider other)
    {
        playableDirector.Play();
        gameObject.SetActive(StayActive);
    }



}
