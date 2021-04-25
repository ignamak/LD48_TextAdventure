using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI message")][System.Serializable]
public class AImessage : ScriptableObject
{
    public string aiName;
    [TextArea(10, 14)] public string messageText;

    public PlayerAnswer[] playerAnswers;

    public string GetAIName()
    {
        return aiName;
    }
    public string GetMessage()
    {
        return messageText;
    }
}

