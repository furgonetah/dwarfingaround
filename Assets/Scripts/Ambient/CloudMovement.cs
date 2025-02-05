using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    private Transform position;    
    void Start()
    {
        position = gameObject.GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        position.position = new Vector3(position.position.x-0.005f, position.position.y, position.position.z);
        if (position.position.x < -13f)
        {
            position.position = new Vector3(13f, position.position.y, position.position.z);
        }
    }
}
