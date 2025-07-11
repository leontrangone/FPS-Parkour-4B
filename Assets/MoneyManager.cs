using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    int amount = 0;
    public float money;
    public UIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateMoney(float amount)
    {
        money += amount;
        uiManager.UpdateMoneyText(money.ToString());
        return true;
    }
}
