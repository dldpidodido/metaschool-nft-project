using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class Drawings : MonoBehaviour
{
    // �s�W���Sprite�ܶq
    public Sprite drawing_1;
    public Sprite drawing_2;
    public Sprite drawing_3;

    // �b�o�̤��}���Image�ܶq�A�i�H�bInspector���]�m
    public Image sourceImage1;
    public Image sourceImage2;
    public Image sourceImage3;

    // �]�m�ؼФl����Image�ܶq
    private Image targetImage1;
    private Image targetImage2;
    private Image targetImage3;


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
        if (childImages.Length >= 3)
        {
            targetImage1 = childImages[0];
            targetImage2 = childImages[1];
            targetImage3 = childImages[2];
        }

        // ��s�Ĥ@�Ӥl����Image
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

        // ��s�ĤG�Ӥl����Image
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

        // ��s�ĤT�Ӥl����Image
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

