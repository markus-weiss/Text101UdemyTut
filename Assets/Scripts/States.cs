﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "States")]
public class States : ScriptableObject
{
    //Size of TextBoxes
    [TextArea(14,10)] [SerializeField] string storyText;

    [SerializeField] States[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public States[] GetNextStates()
    {
        return nextStates;
    }
}
