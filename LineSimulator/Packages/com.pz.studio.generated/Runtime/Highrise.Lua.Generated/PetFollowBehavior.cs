/*

    Copyright (c) 2024 Pocketz World. All rights reserved.

    This is a generated file, do not edit!

    Generated by com.pz.studio
*/

#if UNITY_EDITOR

using System;
using System.Linq;
using UnityEngine;
using Highrise.Client;
using Highrise.Studio;
using Highrise.Lua;

namespace Highrise.Lua.Generated
{
    [AddComponentMenu("Lua/PetFollowBehavior")]
    [LuaRegisterType(0xf243ea9e11532dfd, typeof(LuaBehaviour))]
    public class PetFollowBehavior : LuaBehaviourThunk
    {
        private const string s_scriptGUID = "206af9c98a7a1f14fb8becdb466263ce";
        public override string ScriptGUID => s_scriptGUID;

        [Header("Follow Settings")]
        [SerializeField] public System.Double _followStartDistance = 4;
        [SerializeField] public System.Double _targetFollowDistance = 1;
        [SerializeField] public System.Boolean _useNavmesh = true;
        [SerializeField] public System.Boolean _teleportIfNoPath = true;
        [Header("Idle Wander Settings")]
        [SerializeField] public System.Boolean _shouldIdleWander = true;
        [SerializeField] public System.Double _percentToWander = 0.67;
        [SerializeField] public System.Double _minTimeBeforeWander = 3;
        [SerializeField] public System.Double _maxTimeBeforeWander = 5;
        [SerializeField] public System.Collections.Generic.List<System.String> _idleAnimationsToPlay = default;

        protected override SerializedPropertyValue[] SerializeProperties()
        {
            if (_script == null)
                return Array.Empty<SerializedPropertyValue>();

            return new SerializedPropertyValue[]
            {
                CreateSerializedProperty(_script.GetPropertyAt(0), _followStartDistance),
                CreateSerializedProperty(_script.GetPropertyAt(1), _targetFollowDistance),
                CreateSerializedProperty(_script.GetPropertyAt(2), _useNavmesh),
                CreateSerializedProperty(_script.GetPropertyAt(3), _teleportIfNoPath),
                CreateSerializedProperty(_script.GetPropertyAt(4), _shouldIdleWander),
                CreateSerializedProperty(_script.GetPropertyAt(5), _percentToWander),
                CreateSerializedProperty(_script.GetPropertyAt(6), _minTimeBeforeWander),
                CreateSerializedProperty(_script.GetPropertyAt(7), _maxTimeBeforeWander),
                CreateSerializedProperty(_script.GetPropertyAt(8), _idleAnimationsToPlay),
            };
        }
    }
}

#endif