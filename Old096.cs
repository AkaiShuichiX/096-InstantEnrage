using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Scp096;
using PlayerRoles.PlayableScps.Scp096;
using UnityEngine;

namespace Old096
{
    public class Old096Plugin : Plugin<Config>
    {
        public override string Name => "Old_096";
        public override string Author => "";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
            Exiled.Events.Handlers.Scp096.AddingTarget += OnAddingTarget;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Exiled.Events.Handlers.Scp096.AddingTarget -= OnAddingTarget;
        }

        private void OnAddingTarget(AddingTargetEventArgs ev)
        {
            Log.Debug("Let Check Rage State");
            if (Config.InstantRage && ev.Scp096.RageState != Scp096RageState.Enraged)
            {
                Debug.Log("SCP - 096 - Instant Rage activated!");
                ev.Scp096.Enrage();
            }
        }
    }
}