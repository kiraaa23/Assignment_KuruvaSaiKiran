using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [Range(0,20)]
    public float playerspeed;
    public float rotationspeed;
    public GameController controller;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime*playerspeed;
        if (Input.GetKeyDown(KeyCode.W)) {
            if (transform.eulerAngles.y != 180)
                transform.eulerAngles = new Vector3(0,0,0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.eulerAngles.y != 270)
            {
               
                transform.eulerAngles = new Vector3(0, 90, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.eulerAngles.y != 90)
                transform.eulerAngles=new Vector3(0, 270, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (transform.eulerAngles.y != 0)
                transform.eulerAngles = new Vector3(0, 180, 0);
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        FruitScript HitFruit = other.GetComponent<FruitScript>();
        Debug.Log(other.gameObject.name);
        if (HitFruit!=null) {

            controller.OnFruitHit(HitFruit.currentFruitProp.Points);
        
        }
        else
        {
            controller.OnBoundaryHit();
        }
    }
}
