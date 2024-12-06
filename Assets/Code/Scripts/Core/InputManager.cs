// ---- Libs ----
using Astral_Odyssey.Input;
using Astral_Odyssey.Scripts.Utilities;
// ---- Code ----
namespace Astral_Odyssey.Scripts.Core
{
    public class InputManager : SingletonBehaviour<InputManager>
    {
        // -- Class properties --

        private InputActions inputs;    // Player inputs.


        // -- Unity methods --

        /// <summary>
        /// Initializes the singleton and other class properties.s
        /// </summary>
        protected override void Awake()
        {
            base.Awake();   // Singleton awake.

            // Init.
            this.inputs = new InputActions();
        }
        /// <summary>
        /// Enable the inputs and register the events.
        /// </summary>
        protected void OnEnable()
        {
            this.inputs.Player.Enable();    // Enable the player inputs.
            // Events.
        }
        /// <summary>
        /// Disable the inputs and unregister the events.
        /// </summary>
        protected void OnDisable()
        {
            this.inputs.Player.Disable();   // Disable the player inputs.
            // Events.
        }
    }
}
