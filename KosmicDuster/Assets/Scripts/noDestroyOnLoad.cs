using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
         DontDestroyOnLoad(this.gameObject);
    }
}
