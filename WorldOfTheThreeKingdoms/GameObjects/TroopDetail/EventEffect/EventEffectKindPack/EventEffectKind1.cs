﻿using GameObjects;
using GameObjects.TroopDetail.EventEffect;
using System;


using System.Runtime.Serialization;namespace GameObjects.TroopDetail.EventEffect.EventEffectKindPack
{

    [DataContract]public class EventEffectKind1 : EventEffectKind
    {
        public override void ApplyEffectKind(Person person)
        {
            if (person.LocationTroop != null)
            {
                person.LocationTroop.SimpleRecoverFromChaos();
            }
        }
    }
}

