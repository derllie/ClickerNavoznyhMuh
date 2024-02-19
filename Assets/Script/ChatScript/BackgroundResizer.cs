using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(RectTransform))]
public class BackgroundResizer : MonoBehaviour
{
    public TMP_Text textObject;
    public RectTransform imageRectTransform;
    public Vector2 padding;

    void Update()
    {
        // Get the rendered values of the text
        textObject.ForceMeshUpdate();
        var textInfo = textObject.textInfo;
        var textBounds = textInfo.meshInfo[0].mesh.bounds;

        // Set the size of the image based on the size of the text
        imageRectTransform.sizeDelta = new Vector2(textBounds.size.x + padding.x, textBounds.size.y + padding.y);
    }
}
