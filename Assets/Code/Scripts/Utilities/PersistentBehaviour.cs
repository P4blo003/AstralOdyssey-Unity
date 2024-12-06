// ---- Libs ----
using UnityEngine;
// ---- Code ----
namespace Astral_Odyssey.Scripts.Utilities
{
    public abstract class PersistentBehaviour<T> : SingletonBehaviour<T> where T : MonoBehaviour
    {
        // -- Unity methods --

        /// <summary>
        /// Prevent the game object to bre destroyed.
        /// </summary>
        protected override void Awake()
        {
            base.Awake();   // SingletonBehaviour awake.
            DontDestroyOnLoad(gameObject);  // Prevent the game object to be destroyed.
        }
    }
}