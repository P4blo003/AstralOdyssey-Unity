// ---- Libs ----
using UnityEngine;
// ---- Code ----
namespace Astral_Odyssey.Scripts.Utilities
{
    public abstract class StaticBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {
        // -- Properties --

        public static T Instance {get; private set;}    // Static instance.


        // -- Unity methods --

        /// <summary>
        /// Initializes the static instance.
        /// </summary>
        protected virtual void Awake()
        {
            Instance = this as T;   // Initializes.
        }
    }
}