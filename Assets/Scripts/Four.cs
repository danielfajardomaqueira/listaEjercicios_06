using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four : MonoBehaviour
{

    public int start;
    public int end;

    // Start is called before the first frame update
    void Start()
    {

        int i = start;
        while (i <= end)
        { 
            if ( i % 5 == 0)
            {
                Debug.Log(i);
            }

            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
