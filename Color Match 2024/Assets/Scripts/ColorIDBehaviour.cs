using UnityEngine;

public class ColorIDBehaviour : IDContainterBehaviour
{
    public ColorIdDataList colorIdDataListObj;

    private void Awake()
    {
        idObj = colorIdDataListObj.currentColor;
    }
}
