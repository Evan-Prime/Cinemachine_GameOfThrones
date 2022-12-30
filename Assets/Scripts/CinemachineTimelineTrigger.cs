using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CinemachineTimelineTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    
    public GameObject player;

    public bool OneTimeTrigger = false; // true = this trigger will self destruct after one use.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {                     
            timeline.Play();
            player.GetComponent<FirstPersonController_Sam>().enabled = false;  
            
            // TODO: Need to add logic to listen for cinemachine event complete and reactivate player control

            // only use if you want to have an event that only triggers once
            if (OneTimeTrigger == true)
            {
                Destroy(this.gameObject);
            }

        }
    }
}
