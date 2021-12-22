using UnityEngine;
using UnityEngine.XR;
using System.Collections.Generic;

/// <summary>
/// 此類別用來處理 2020 以上 (包含) 版本遺失的 isPresent 資料
/// XR 設定程序
/// 展示資料傳回
/// </summary>
public static class XRSettingsUtil
{
    /// <summary>
    /// 是否展示中
    /// </summary>
    public static bool isPresent()
    {
        var xrDisplaySubsystems = new List<XRDisplaySubsystem>();       // 新增 子系統 集合
        SubsystemManager.GetInstances(xrDisplaySubsystems);             // 取得 子系統 實體物件

        foreach (var xrDisplay in xrDisplaySubsystems)                  // 遍尋 清單內 所有子系統
        {
            if (xrDisplay.running) return true;                         // 如果 子系統 正在執行中 就傳回 true
        }

        return false;                                                   // 沒有執行就傳回 false
    }
}
