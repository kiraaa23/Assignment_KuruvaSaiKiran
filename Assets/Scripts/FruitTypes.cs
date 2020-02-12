using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Fruits",fileName =" ScriptableObjects/New Fruit")]
public class FruitTypes : ScriptableObject
{
    public List<FruitProp> Fruits;
}
