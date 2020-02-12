using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitScript : MonoBehaviour
{
   public FruitProp currentFruitProp;
    public Material fruitmat;

    

    private void Start()
    {
        if (currentFruitProp != null) {

            fruitmat.color = currentFruitProp.color;
        } 
    }

    
}
[System.Serializable]
public class FruitProp {

    public Color color;
    public int Points;


}