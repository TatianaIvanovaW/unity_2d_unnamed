using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static tags;

public class CollectPumpkin : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.1f;
    public int amountPumkinCollected = 0;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == tags.pumpkin)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            amountPumkinCollected += 1;
            Destroy(other.gameObject, destroyDelay);
        }
    }
}
