using UnityEngine;

namespace _1_Game.Scripts
{
    public class AnimalAnimationSelector : MonoBehaviour
    {
        [SerializeField] private string _state = "Idle_A";
        [SerializeField] private bool _selectRandomAnimation = true;

        [SerializeField] private string[] _stateNames =
        {
            "Attack", "Clicked", "Eat", "Fly", "Idle_A", "Idle_B", "Idle_C", "Roll", "Sit", "Swim", "Bounce", "Death",
            "Fear", "Hit", "Idle_B", "Jump", "Run", "Spin", "Walk"
        }; 
        
        private void Start()
        {
            var animator = GetComponentInChildren<Animator>();
            animator.Play(_state);

            if (_selectRandomAnimation)
            {
                // var controller = new AnimatorOverrideController(animator.runtimeAnimatorController);
                // animator.runtimeAnimatorController = controller;
                animator.Play(_stateNames[Random.Range(0, _stateNames.Length)]);
            }
        }
    }
}