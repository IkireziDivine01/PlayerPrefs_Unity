using UnityEngine;
using TMPro;
public class ScriptableObjectManager : MonoBehaviour
{
    public ScriptableObjectSample scriptableObjectSample;
    public TMP_Text textMeshProUGUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textMeshProUGUI.text = scriptableObjectSample.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
