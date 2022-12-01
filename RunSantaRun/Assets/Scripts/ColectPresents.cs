using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColectPresents : MonoBehaviour
{
 public AudioSource PresentFx;
       void OnTriggerEnter(Collider other)
    {
        PresentFx.Play();
        this.gameObject.SetActive(false);
    }
}
