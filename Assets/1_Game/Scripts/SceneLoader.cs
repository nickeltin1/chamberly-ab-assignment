using nickeltin.Scenes.Runtime;
using UnityEngine;

namespace _1_Game.Scripts
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private SceneSourceAsset _scene;
        [SerializeField] private bool _loadAtStart;

        private void Start()
        {
            if (_loadAtStart)
            {
                _scene.LoadAsync(true, true);
            }
        }
    }
}