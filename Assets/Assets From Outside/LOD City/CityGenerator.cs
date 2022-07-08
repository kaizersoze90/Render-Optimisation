using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGenerator : MonoBehaviour
{
    [SerializeField] GameObject cityBuilding;
    [SerializeField] int rows = 5;
    [SerializeField] int cols = 5;

    void Start()
    {
        for (int z = 0; z < rows; z++)
        {
            for (int x = 0; x < cols; x++)
            {
                Vector3 pos = new Vector3(x * 20, 0, z * 20);
                Instantiate(cityBuilding, pos, Quaternion.identity);
            }
        }

    }
}
