// ---- Libs ----
using UnityEngine;
// ---- Code ----
namespace Astral_Odyssey.Scripts.Utilities
{
    public abstract class SingletonBehaviour<T> : StaticBehaviour<T> where T : MonoBehaviour
    {
        // -- Unity methods --

        /// <summary>
        /// If the instance is already initialized (not null), destroys the game object
        /// to prevent having more than one instance.
        /// </summary>
        protected override void Awake()
        {
            if(Instance != null){Destroy(gameObject);}  // Destroys the game object if it's null.
            base.Awake();   // StaticBehaviour awake.
        }
    }
}