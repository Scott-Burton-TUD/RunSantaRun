using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectPresents : MonoBehaviour
{
 public AudioSource PresentFx;
       void OnTriggerEnter(Collider other)
    {
        PresentFx.Play();
        CollactableControl.presentCount += 1;
        this.gameObject.SetActive(false);
    }
}
