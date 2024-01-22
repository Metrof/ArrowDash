using UnityEngine;

public class MenuCanvas : MonoBehaviour
{
    [SerializeField] private MenuSettingPanel _settingPanel;
    [SerializeField] private MainPanel _mainPanel;
    [SerializeField] private LvlChoisePanel _lvlChoisePanel;

    public LvlChoisePanel LvlChoisePanel { get { return _lvlChoisePanel; } }
    public MainPanel MainPanel {  get { return _mainPanel; } }
    public MenuSettingPanel SettingPanel { get {  return _settingPanel; } }
}
