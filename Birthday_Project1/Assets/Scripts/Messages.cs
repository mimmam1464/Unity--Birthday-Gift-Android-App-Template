using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messages : MonoBehaviour
{
    public MessagesArray[] messages;    
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]
    public struct MessagesArray
    {
        public string name;
        public string message;
        public Sprite image1;
        public Sprite image2;
    }
}
