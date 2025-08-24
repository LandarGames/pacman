using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMANAGER : MonoBehaviour
{
    [SerializeField] private GameObject[] _slide;

    public void NewSlide(int index)
    {
        foreach (GameObject go in _slide)
        {
            go.SetActive(false);
        }
        _slide[index].SetActive(true);
    }

    public void NewScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
