using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three : MonoBehaviour
{
    public int Number;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = Number; i >= 0; i--)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
