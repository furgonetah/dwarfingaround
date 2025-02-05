using System;
using UnityEngine;

public class DwarfPet : MonoBehaviour
{
    public bool isMining = true;
    public Animator animator;
    public GameObject prefab;
    private Transform position;
    void Start()
    {
        position = gameObject.GetComponent<Transform>();
    }
    void Update()
    {
        Mining();
        
    }

    private void FixedUpdate()
    {
        position.localPosition = new Vector3(position.localPosition.x-5f, position.localPosition.y, position.localPosition.z);
        if (position.localPosition.x <= -1600f)
        {
            position.localPosition = new Vector3(1600f, position.localPosition.y, position.localPosition.z);
        }
    }

    private void Mining()
    {
        isMining = true;
        Invoke("DeactivateMining", 1.083f);
    }

    private void DeactivateMining()
    {
        isMining = false;
        Invoke("Mining", 1.083f);
    }
    
    

}
