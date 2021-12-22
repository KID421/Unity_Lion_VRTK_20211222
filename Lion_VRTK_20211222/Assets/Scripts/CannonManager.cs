using UnityEngine;

/// <summary>
/// 大砲管理器
/// </summary>
public class CannonManager : MonoBehaviour
{
    /// <summary>
    /// 使用大砲
    /// </summary>
    public void UseCannon()
    {
        print("大砲發射~");
    }

    /// <summary>
    /// 不使用大砲 (使用之後)
    /// </summary>
    public void UnuseCannon()
    {
        print("發射完畢，生成砲彈~");
    }
}
