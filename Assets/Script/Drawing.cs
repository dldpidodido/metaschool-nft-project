using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class Drawing : MonoBehaviour
{
    // 新增兩個Sprite變量
    public Sprite drawing;

    // 在這裡公開Image變量，可以在Inspector中設置
    public Image sourceImage;

    // 設置目標子物件的Image變量
    private Image targetImage;


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
            targetImage = childImages[0];


        // 更新第一個子物件的Image
        if (sourceImage != null && targetImage != null)
        {
            if (drawing != null)
            {
                sourceImage.sprite = drawing;
            }
            targetImage.sprite = sourceImage.sprite;

            targetImage.SetNativeSize();
        }
        else
        {
            Debug.LogWarning("SourceImage1 or TargetImage1 is not set.");
        }
    }
}

