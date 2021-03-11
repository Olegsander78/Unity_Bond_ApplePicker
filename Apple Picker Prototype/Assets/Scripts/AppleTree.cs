using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    //Pattern creating Apple
    public GameObject applePrefab;

    //Velocity moving Apple
    public float speed = 1f;

    //The distance at which the direction of movement of the apple tree should change.
    public float leftAndRightEdge = 10f;

    //The likelihood of an accidental change in direction.
    public float chanceToChangeDirection = 0.1f;

    //The frequency at which the apples are instantiated.
    public float secondsBetweenAppleDrops = 1f;
         
    void Start()
    {
        //Drop apples once a second.
    }

    // Update is called once per frame
    void Update()
    {
        //Simple moving
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

      //Change of direction
    }
}
