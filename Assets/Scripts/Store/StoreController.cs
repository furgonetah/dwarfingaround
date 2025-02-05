using TMPro;
using UnityEngine;

public class StoreController : MonoBehaviour
{
    [Header("Score Elements")] 
    public int stoneScore;
    public int goldScore;
    public int goldPrice=50;
    public int spawnDwarfLevel = 1;
    public int dwarfPowerLevel = 1;
    public int spawnDwarfPrice = 1;
    public int dwarfPowerPrice = 2;
    
    [Header("UI Elements")] 
    public TextMeshProUGUI stoneText;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI goldPriceText;
    public TextMeshProUGUI spawnLevelText;
    public TextMeshProUGUI spawnPriceText;
    public TextMeshProUGUI dwarfPowerText;
    public TextMeshProUGUI dwarfPowerPriceText;
    
    [Header("Spawn Elements")]
    public GameObject dwarfPrefab;
    public Transform spawnPoint;
    public bool defaultAutoMiner = true;

    void Start()
    {
        stoneScore = 0;
        goldScore = 0;
        spawnDwarfLevel = 1;
        dwarfPowerLevel = 1;
        dwarfPowerPrice = 2;
        spawnDwarfPrice = 1;
    }

    void Update()
    {
        UIHandler();
    }
    private void UIHandler()
    {
        stoneText.text = stoneScore.ToString();
        goldText.text = goldScore.ToString();
        goldPriceText.text = goldPrice.ToString();
        spawnLevelText.text = spawnDwarfLevel.ToString();
        spawnPriceText.text = spawnDwarfPrice.ToString();
        dwarfPowerText.text = dwarfPowerLevel.ToString();
        dwarfPowerPriceText.text = dwarfPowerPrice.ToString();
    }
    public void IncreaseMiningPower()
    {
        if (stoneScore >= dwarfPowerPrice)
        {
            dwarfPowerLevel++;
            stoneScore -= dwarfPowerPrice;
            dwarfPowerPrice = dwarfPowerPrice * 2;
        }
        
    }

    public void SpawnDwarf()
    {
        if (goldScore >= spawnDwarfPrice)
        {
            GameObject newDwarf = Instantiate(dwarfPrefab, spawnPoint.position, Quaternion.identity);

            DwarfController dwarfController = newDwarf.GetComponent<DwarfController>();
            if (dwarfController != null)
            {
                dwarfController.storeController = this; 
                dwarfController.isAutoMiner = defaultAutoMiner; 
            }

            goldScore -= spawnDwarfPrice;
            spawnDwarfLevel++;
            spawnDwarfPrice *= 2; 
        }
    }

    public void BuyGold()
    {
        if (stoneScore >= goldPrice)
        {
            goldScore ++;
            stoneScore -= goldPrice;
        }
        
    }
    
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#else
            Application.Quit(); 
#endif
    }

    
}
