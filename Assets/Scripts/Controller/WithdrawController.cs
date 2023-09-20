using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WithdrawController : MonoBehaviour
{
    public Text cashText; // ����
    public Text balanceText; // �ܾ�
    public InputField WithdrawInput; // �Է�â
    public GameObject WarningPanel;


    private DataManager dataManager;

    private void Start()
    {
        dataManager = DataManager.instance;
        UpdateUI();
    }

    private void UpdateUI()
    {
        cashText.text = dataManager.cash.ToString("N0"); //NO�� ���� ���� ǥ�� ����
        balanceText.text = dataManager.balance.ToString("N0");
    }

    private void Withdraw(int amount)
    {
        if (dataManager.balance >= amount)
        {
            dataManager.cash += amount;
            dataManager.balance -= amount;
            UpdateUI();
        }
        else
        {
            WarningPanel.SetActive(true);
        }
    }

    public void Withdraw1()
    {
        Withdraw(10000);
    }

    public void Withdraw2()
    {
        Withdraw(30000);
    }

    public void Withdraw3()
    {
        Withdraw(50000);
    }

    public void Withdraw4()
    {
        if (int.TryParse(WithdrawInput.text, out int amount))
        {
            Withdraw(amount);
        }
        //�߸��� �Է½� ���â
    }

    public void CloseWarningPanel()
    {
        WarningPanel.SetActive(false);
    }
}
