using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class FruitSpawner : MonoBehaviour
{
    public Vector3 center;
    public Vector3 Size;
    public GameObject FruitPrefab;
    
    public FruitTypes fruittypes;
    GameObject RandomFruit;
    private void Start()
    {
        GenerateFruit();
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center,Size);
    }
    
    public void GenerateFruit() {

        FruitProp RamFruitProp = fruittypes.Fruits[Random.Range(0,3)];
        Vector3 FruitPos = center + new Vector3(Random.Range(-Size.x/2,Size.x/2),0,Random.Range(-Size.z/2,Size.z/2));
        if (RandomFruit == null)
        {
            RandomFruit= Instantiate(FruitPrefab, FruitPos, Quaternion.identity);
            RandomFruit.GetComponent<FruitScript>().currentFruitProp = RamFruitProp;
        }
        else
        {
            
            
            RandomFruit.transform.position = FruitPos;
            RandomFruit.GetComponent<FruitScript>().currentFruitProp = RamFruitProp;
        }
    
    }
     
}
