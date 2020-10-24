using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grassScript : MonoBehaviour
{
	public Sprite[] grasses;
    // Start is called before the first frame update
    void Start()
    {
        int k=Random.Range(0,grasses.Length);
        GetComponent<SpriteRenderer>().sprite=grasses[k];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
