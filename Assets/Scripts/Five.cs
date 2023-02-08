using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Five : MonoBehaviour
{
    public int[] array;

    private int num = 0;

    // Start is called before the first frame update
    void Start()
    {

        foreach (int Sum in array)
        {
            num += Sum;
            
        }
        Debug.Log(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
