using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private Transform player;
    public float speed = 1.5f;
    private float stop_distance = 5f;
    public float floorHeight = 0.5f; // Hauteur minimale (ajuste selon ton terrain)

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if(Vector3.Distance(player.transform.position, transform.position) < stop_distance && !HudManager.pause)
        {
            // Fixe la hauteur Y à la valeur du sol
            Vector3 targetPosition = new Vector3(player.transform.position.x, floorHeight, player.transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}
