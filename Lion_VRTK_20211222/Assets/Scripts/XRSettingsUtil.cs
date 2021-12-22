using UnityEngine;
using UnityEngine.XR;
using System.Collections.Generic;

/// <summary>
/// �����O�ΨӳB�z 2020 �H�W (�]�t) �����򥢪� isPresent ���
/// XR �]�w�{��
/// �i�ܸ�ƶǦ^
/// </summary>
public static class XRSettingsUtil
{
    /// <summary>
    /// �O�_�i�ܤ�
    /// </summary>
    public static bool isPresent()
    {
        var xrDisplaySubsystems = new List<XRDisplaySubsystem>();       // �s�W �l�t�� ���X
        SubsystemManager.GetInstances(xrDisplaySubsystems);             // ���o �l�t�� ���骫��

        foreach (var xrDisplay in xrDisplaySubsystems)                  // �M�M �M�椺 �Ҧ��l�t��
        {
            if (xrDisplay.running) return true;                         // �p�G �l�t�� ���b���椤 �N�Ǧ^ true
        }

        return false;                                                   // �S������N�Ǧ^ false
    }
}
