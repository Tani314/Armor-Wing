using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainScript : MonoBehaviour
{
    private Animation anima;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void train()
    {
        anima.Play("Armature|Idel_New");
    }
}
