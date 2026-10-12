using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
   
    void FixedUpdate()
    {
        if (target != null)
        {
            
            Vector2 nexcamposition = Vector2.Lerp(transform.position, target.position, cameraSpeed * Time.deltaTime);
            float clampx = Mathf.Clamp(nexcamposition.x, minX, maxX);
            float clampy = Mathf.Clamp(nexcamposition.y, minY, maxY);
            transform.position = new Vector3(clampx, clampy, -10f);
        }
    }
}
