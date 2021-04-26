using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI message")][System.Serializable]
public class AImessage : ScriptableObject
{
    public string aiName;
    public enum Type
    {
        PLAYER_STARTS,
        AI_STARTS_FOLLOWS_TALKING,
        AI_STARTS_WAITING_PLAYER
    }
    public Type conversationType;
    [TextArea(10, 14)] public string messageText;

    public PlayerAnswer[] playerAnswers;
    public AImessage nextAiMessage;

    public string GetAIName()
    {
        return aiName;
    }
    public string GetMessage()
    {
        return messageText;
    }
}

