using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int age = 5;
    public string prenom = "";
    public float spreed = 5.2f;
    public bool is_active = true;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(prenom);
        cube.transform.localScale = new Vector3(3,3,3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
