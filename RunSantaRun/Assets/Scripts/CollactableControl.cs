using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollactableControl : MonoBehaviour
{
    public static int presentCount;
    public GameObject presentCountDisplay;

    void Update()
    {
        presentCountDisplay.GetComponent<Text>().text = "" + presentCount;
    }
}
