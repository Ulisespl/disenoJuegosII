using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject inventory;
    public TMP_Text moneyCountText;
    public TMP_Text woodCountText;
    public TMP_Text meatCountText;

    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OpenOrCloseInventory()
    {
        inventory.SetActive(!inventory.activeSelf);
    }

    public void UpdateMoneyCount(int value)
    {
        moneyCountText.text = value.ToString();
    }

    public void UpdateWoodCount(int value)
    {
        woodCountText.text = value.ToString();
    }   
    
    public void UpdateMeatCount(int value)
    {
        meatCountText.text = value.ToString();
    }
}
