using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepositController : MonoBehaviour
{
    public Text cashText; // ����
    public Text balanceText; // �ܾ�
    public InputField DespositInput; // �Է�â
    public GameObject WarningPanel;


    private int cash = 100000; // �ʱ� ����
    private int balance = 50000; // �ʱ� �ܾ�

    private void UpdateUI()
    {
        cashText.text = cash.ToString("N0"); //NO�� ���� ���� ǥ�� ����
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
        //�߸��� �Է½� ���â
    }

    public void CloseWarningPanel()
    {
        WarningPanel.SetActive(false);
    }
}
