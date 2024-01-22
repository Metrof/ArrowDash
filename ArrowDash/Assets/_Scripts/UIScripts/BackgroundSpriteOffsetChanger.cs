using UnityEngine;

public class BackgroundSpriteOffsetChanger : MonoBehaviour
{
    private Renderer _renderer;
    private Material m_Material;
    private float _distance;

    [SerializeField] float _speed = 0.5f;

    private float _defaultSpeed;
    private void Awake()
    {
        _defaultSpeed = _speed;
        _renderer = GetComponent<Renderer>();
        m_Material = _renderer.material;
    }
    public void SetMaterial(Material material)
    {
        m_Material = material;
        _renderer.material = m_Material;
    }
    public void SetColor(Color color)
    {
        m_Material.color = color;
    }
    public void ChangeSpeed(float speed)
    {
        _speed = speed == -1 ? _defaultSpeed : speed;
    }
    public void ReturnTexturePos()
    {
        m_Material.SetTextureOffset("_MainTex", Vector2.zero);
    }
    private void Update()
    {
        _distance += Time.deltaTime * _speed;
        m_Material.SetTextureOffset("_MainTex", Vector2.left * _distance);
    }
}
