using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactManager : MonoBehaviour
{
    public GameObject emptyConversation;
    public GameObject aiConversation1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenConversation()
    {
        if (aiConversation1)
        {
            emptyConversation.SetActive(false);
        }
        aiConversation1.SetActive(true);
    }
}
