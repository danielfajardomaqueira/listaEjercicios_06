using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two : MonoBehaviour
{
    public string[] phrase;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (i < phrase.Length)
        {
            Debug.Log(phrase[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
