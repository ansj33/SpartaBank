using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositController : MonoBehaviour
{
    public Text cashText; // 현금
    public Text balanceText; // 잔액
    public InputField DespositInput; // 입력창
    public GameObject WarningPanel;


    private int cash = 100000; // 초기 현금
    private int balance = 50000; // 초기 잔액

    private void UpdateUI()
    {
        cashText.text = cash.ToString("N0"); //NO를 쓰면 단위 표기 가능
        balanceText.text = balance.ToString("N0");
    }

    private void Deposit(int amount)
    {
        if (cash >= amount)
        {
            cash -= amount;
            balance += amount;
            UpdateUI();
        }
        else
        {
            WarningPanel.SetActive(true);
        }
    }

    public void Deposit1()
    {
        Deposit(10000);
    }

    public void Deposit2()
    {
        Deposit(30000);
    }

    public void Deposit3()
    {
        Deposit(50000);
    }

    public void Deposit4()
    {
        if (int.TryParse(DespositInput.text, out int amount))
        {
            Deposit(amount);
        }
        //잘못된 입력시 경고창
    }

    public void CloseWarningPanel()
    {
        WarningPanel.SetActive(false);
    }
}
