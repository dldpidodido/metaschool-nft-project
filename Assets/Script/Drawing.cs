using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class Drawing : MonoBehaviour
{
    // �s�W���Sprite�ܶq
    public Sprite drawing;

    // �b�o�̤��}Image�ܶq�A�i�H�bInspector���]�m
    public Image sourceImage;

    // �]�m�ؼФl����Image�ܶq
    private Image targetImage;


    void Start()
    {
        // �b�B��ɩM�s��Ҧ����������s
        UpdateTargetImages();
    }

    // OnValidate�|�b�ݩʧ��ܮɦ۰ʽե�
    void OnValidate()
    {
        // �b�s�边�������s
        UpdateTargetImages();
    }

    // ��s�l����Image�ե�
    void UpdateTargetImages()
    {
        // ����l���󤤪�Image component
        Image[] childImages = GetComponentsInChildren<Image>();
            targetImage = childImages[0];


        // ��s�Ĥ@�Ӥl����Image
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

