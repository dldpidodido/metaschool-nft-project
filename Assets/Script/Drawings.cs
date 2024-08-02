using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class Drawings : MonoBehaviour
{
    // 新增兩個Sprite變量
    public Sprite drawing_1;
    public Sprite drawing_2;
    public Sprite drawing_3;

    // 在這裡公開兩個Image變量，可以在Inspector中設置
    public Image sourceImage1;
    public Image sourceImage2;
    public Image sourceImage3;

    // 設置目標子物件的Image變量
    private Image targetImage1;
    private Image targetImage2;
    private Image targetImage3;


    void Start()
    {
        // 在運行時和編輯模式中都執行更新
        UpdateTargetImages();
    }

    // OnValidate會在屬性改變時自動調用
    void OnValidate()
    {
        // 在編輯器中執行更新
        UpdateTargetImages();
    }

    // 更新子物件的Image組件
    void UpdateTargetImages()
    {
        // 獲取子物件中的Image component
        Image[] childImages = GetComponentsInChildren<Image>();
        if (childImages.Length >= 3)
        {
            targetImage1 = childImages[0];
            targetImage2 = childImages[1];
            targetImage3 = childImages[2];
        }

        // 更新第一個子物件的Image
        if (sourceImage1 != null && targetImage1 != null)
        {
            if (drawing_1 != null)
            {
                sourceImage1.sprite = drawing_1;
            }
            targetImage1.sprite = sourceImage1.sprite;

            targetImage1.SetNativeSize();
        }
        else
        {
            Debug.LogWarning("SourceImage1 or TargetImage1 is not set.");
        }

        // 更新第二個子物件的Image
        if (sourceImage2 != null && targetImage2 != null)
        {
            if (drawing_2 != null)
            {
                sourceImage2.sprite = drawing_2;
            }
            targetImage2.sprite = sourceImage2.sprite;

            targetImage2.SetNativeSize();
        }
        else
        {
            Debug.LogWarning("SourceImage2 or TargetImage2 is not set.");
        }

        // 更新第三個子物件的Image
        if (sourceImage3 != null && targetImage3 != null)
        {
            if (drawing_3 != null)
            {
                sourceImage3.sprite = drawing_3;
            }
            targetImage3.sprite = sourceImage3.sprite;

            targetImage3.SetNativeSize();
        }
        else
        {
            Debug.LogWarning("SourceImage3 or TargetImage3 is not set.");
        }
    }
}

