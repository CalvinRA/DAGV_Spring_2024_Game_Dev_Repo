using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    // Start is called before the first frame update
    private void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChagneRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }
}
