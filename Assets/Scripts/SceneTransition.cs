using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string secondSceneName = "AsteroidsGame"; // Name of your second scene.
    [SerializeField] public float delayTime = 7.0f;
    void Start()
    {
        StartCoroutine(TransitionToSecondScene());
    }

    IEnumerator TransitionToSecondScene()
    {
        // Wait for 5 seconds before transitioning to the second scene.
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene(secondSceneName);

    }


}
