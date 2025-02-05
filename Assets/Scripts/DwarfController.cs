using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DwarfController : MonoBehaviour
{
    private Transform currentPosition;
    public Animator animator;
    
    [Header("Dwarf Properties")] 
    public float minePosition = 5.75f;
    public float dwarfSpeed = 0.05f;
    public bool isAutoMiner = false;
    private bool isMining;
    private float autoMineTimer = 0f;
    public float autoMineInterval = 1.083f;
    
    [Header("External References")]
    public StoreController storeController;
    
    void Start()
    {
        currentPosition = gameObject.GetComponent<Transform>();
        animator.SetBool("isMoving", true);
        animator.SetBool("isMining", false);
        isMining = false;
    }
    private void Update()
    {    
        if (isAutoMiner)
        {
            AutoMining();
        }
        else
        {
            ManualMining();
        }
    }
    void FixedUpdate()
    {
        DwarfEnters();
    }
    private void DwarfEnters()
    {
        if (currentPosition.position.x <= minePosition)
        {
            currentPosition.position = new Vector2(currentPosition.position.x + dwarfSpeed, currentPosition.position.y);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }
    
    private void Mining()
    {
        isMining = true;
        animator.SetBool("isMining", true);
        storeController.stoneScore = storeController.stoneScore + storeController.dwarfPowerLevel;

        Invoke("DeactivateMining", 1.083f);
    }

    private void DeactivateMining()
    {
        isMining = false;
        animator.SetBool("isMining", false);
    }

    private void ManualMining()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isMining)
        {
            Mining();
        }
    }
    private void AutoMining()
    {
        if (autoMineTimer <= 0f)
        {
            if (!isMining)
            {
                Mining();
            }
            autoMineTimer = autoMineInterval; 
        }
        else
        {
            autoMineTimer -= Time.deltaTime; 
        }
    }
    

    
}