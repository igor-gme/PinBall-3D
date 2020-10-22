﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBehaviour : MonoBehaviour
{
    // Mark if should reset position.
    public bool resetPosition = false;

    // Object to reset position. Defaults to current object.
    public GameObject objectToResetPosition;

    // Mark if should reset trigger
    public bool resetTrigger = false;

    // Object with trigger. Defaults to current.
    public GameObject objectWithTrigger;

    // Will you reset the trigger to true or to false? Defaults to true;
    public bool resetTriggerTo = true;

    private Collider trigger;
    private Vector3 originalPosition;

    void Start()
    {
        if(resetPosition)
        {
            if(objectToResetPosition == null)
            {                
                objectToResetPosition = gameObject;
            }

            originalPosition = objectToResetPosition.transform.localPosition;
        }

        if(resetTrigger)
        {
            if(objectWithTrigger == null)
            {
                objectWithTrigger = gameObject;
            }

            trigger = objectWithTrigger.GetComponent<Collider>();        
        }

    }

    public void Reset()
    {        

        if(resetPosition)
        {
            objectToResetPosition.transform.localPosition = originalPosition;
        }

        if(resetTrigger)
        {
            trigger.enabled = resetTriggerTo;
        }
    }

}

