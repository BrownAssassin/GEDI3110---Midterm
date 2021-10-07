using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class GenerateRandomPosition : MonoBehaviour
{
    [DllImport("Midterm Quiz")]
    private static extern int GenerateRandomFloat(int min, int max);
    
    public Rigidbody rigidbody;
    public Transform transform;

    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        time += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0.5 && time < 1.5) {
            Instantiate(rigidbody, new Vector3(GenerateRandomFloat(-40, 40), transform.position.y + 20, GenerateRandomFloat(-40, 40)), Quaternion.identity);
        }
    }
}
