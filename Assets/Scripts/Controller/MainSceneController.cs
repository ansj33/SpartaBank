using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneController : MonoBehaviour
{
    public Text cashText; // ����
    public Text balanceText; // �ܾ�
    private DataManager dataManager;

    private void Start()
    {
        dataManager = DataManager.instance;
        UpdateUI();
    }

    private void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        cashText.text = dataManager.cash.ToString("N0"); //NO�� ���� ���� ǥ�� ����
        balanceText.text = dataManager.balance.ToString("N0");
    }
}
