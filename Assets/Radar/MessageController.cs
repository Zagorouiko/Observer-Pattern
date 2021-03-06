﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MessageController : MonoBehaviour
{
    Text message;
   void Start()
    {
        message = GetComponent<Text>();
        message.enabled = false;
    }

    public void SetMessage(GameObject gameObject)
    {
        message.text = "You picked up an item";
        message.enabled = true;
        Invoke("TurnOff", 2);
    }

    void TurnOff()
    {
        message.enabled = false;
    }
}
