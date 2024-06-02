using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class startmenU : MonoBehaviour
{
    public TMP_Text easyrecord;
    public TMP_Text normalrecord;
    public TMP_Text hardrecord;
    // ������������� �� ������� GetDataEvent � OnEnable
    private void OnEnable() => YandexGame.GetDataEvent += GetLoad;

    // ������������ �� ������� GetDataEvent � OnDisable
    private void OnDisable() => YandexGame.GetDataEvent -= GetLoad;

    private void Start()
    {
        // ��������� ���������� �� ������
        if (YandexGame.SDKEnabled == true)
        {
            // ���� ����������, �� ��������� ��� ����� ��� ��������
            GetLoad();

            // ���� ������ ��� �� �����������, �� ����� �� ���������� � ������ Start,
            // �� �� ���������� ��� ������ ������� GetDataEvent, ����� ��������� �������
        }
    }

    // ��� ����� ��� ��������, ������� ����� ����������� � ������
    public void GetLoad()
    {
        easyrecord.text = YandexGame.savesData.easyrecords.ToString();
        normalrecord.text = YandexGame.savesData.normalrecords.ToString(); 
        hardrecord.text     =   YandexGame.savesData .hardrecords.ToString();
    }

}
