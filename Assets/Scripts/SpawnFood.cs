﻿using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour
{
    // Food
    public GameObject FoodPrefab;
    // Borders
   
    public Transform BorderTop;
    public Transform BorderBottom;
    public Transform BorderLeft;
    public Transform BorderRight;
    // Use this for initialization
    void Start()
    {
        // Spawn food every 4 seconds, starting in 3
        InvokeRepeating("Spawn", 3, 6);
    }

    // Spawn one piece of food
    void Spawn()
    {
        try {
           

            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Clone");
            for (var i = 0; i < gameObjects.Length; i++)
                Destroy(gameObjects[i]);
            
            int x = (int)Random.Range(BorderLeft.position.x, BorderRight.position.x);

            // y position between top & bottom border
            int y = (int)Random.Range(BorderBottom.position.y, BorderTop.position.y);

            // Instantiate the food at (x, y)
            Instantiate(FoodPrefab, new Vector2(x, y), Quaternion.identity); // default rotation
        }
        catch
        {
            // x position between left & right border
            int x = (int)Random.Range(BorderLeft.position.x, BorderRight.position.x);

            // y position between top & bottom border
            int y = (int)Random.Range(BorderBottom.position.y, BorderTop.position.y);

            // Instantiate the food at (x, y)
            Instantiate(FoodPrefab, new Vector2(x, y), Quaternion.identity); // default rotation
        }
       



    }
}
