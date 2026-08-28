using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;
    public static UIManager Instance;

   void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }
}
