﻿using YARG.Core.Chart;
using YARG.Core.Input;

namespace YARG.Core.Engine.Drums
{
    public class DrumsEngineState : BaseEngineState
    {
        /// <summary>
        /// The integer value for the pad that was inputted this update. <c>null</c> is none, and the value can
        /// be based off of <see cref="FourLaneDrumPad"/> or <see cref="FiveLaneDrumPad"/>.
        /// </summary>
        public int? PadHit;
        public float? HitVelocity;
        public DrumsAction? Action;

        public override void Reset()
        {
            base.Reset();

            PadHit = null;
            HitVelocity = null;
            Action = null;
        }
    }
}