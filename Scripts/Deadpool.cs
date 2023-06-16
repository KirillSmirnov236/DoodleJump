using UnityEngine.SceneManagement;
using UnityEngine;

public class Deadpool : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        if(_target.position.y <= transform.position.y)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
