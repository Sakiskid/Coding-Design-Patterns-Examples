namespace DesignPatterns.State {

    class Player
    {
        private PlayerState state = null;

        // When constructed, Transition to starting state
        public Player (PlayerState state) {
            this.TransitionTo(state);
        }

        // This switches the current State and provides context (player) reference to the State
        public void TransitionTo (PlayerState state) {
            this.state = state;
            this.state.SetPlayerContext(this);
        }

        public void StandUp() {
            this.state.StandUp();
        }

        public void LieDown() {
            this.state.LieDown();
        }
    }

    abstract class PlayerState {
        // This is the Context reference, so that the State and access Context to transition to another state
        protected Player player;

        public void SetPlayerContext (Player player) {
            this.player = player;
        }

        public abstract void StandUp();

        public abstract void LieDown();
    }

    #region /////// Player States ///////

        // Player is standing
    class PlayerStateStand : PlayerState {
        public override void StandUp() {
            GUIConsole.Instance.Log("PlayerState (standing): Can't stand up any further! *struggles*");
            // Don't transition
        }

        public override void LieDown() {
            GUIConsole.Instance.Log("PlayerState (standing): Gonna go ahead and crouch now.");
            player.TransitionTo(new PlayerStateCrouch());
        }
    }

    // Player is crouching
    class PlayerStateCrouch : PlayerState {
        public override void StandUp() {
            GUIConsole.Instance.Log("PlayerState (crouching): Going to stand up now!");
            player.TransitionTo(new PlayerStateStand());
        }

        public override void LieDown() {
            GUIConsole.Instance.Log("PlayerState (crouching): Laying down to take a nap.");
            player.TransitionTo(new PlayerStateLaying());
        }
    }

    // Player is laying
    class PlayerStateLaying : PlayerState {
        public override void StandUp() {
            GUIConsole.Instance.Log("playerState (laying): Moving into a crouching position...");
            player.TransitionTo(new PlayerStateCrouch());
        }
        
        public override void LieDown() {
            GUIConsole.Instance.Log("PlayerState (laying): I literally can't lay down any more than this '-.-");
            // Do not transition
        }

    }

    #endregion
}