using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeChildScript : MonoBehaviour
{
   public Transform Target;
    public Vector3 offset;
    public float TailDistance;
    void Awake()
    {

        int index = transform.GetSiblingIndex()-1;
       Target = transform.parent.GetChild(index).transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector3.Distance(transform.position, Target.position) > TailDistance)
        transform.position = Vector3.Lerp(transform.position,Target.position+offset,Time.deltaTime*8);
    }
}
