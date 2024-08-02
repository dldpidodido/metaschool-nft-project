using UnityEngine;

public class SelfRotate : MonoBehaviour
{
    public float rotateSpeed = 10f; // 每秒旋转的角度

    void Update()
    {
        // 计算旋转量
        Quaternion rotation = Quaternion.Euler(0, rotateSpeed * Time.deltaTime, 0);

        // 应用旋转
        transform.rotation = transform.rotation * rotation;
    }
}
