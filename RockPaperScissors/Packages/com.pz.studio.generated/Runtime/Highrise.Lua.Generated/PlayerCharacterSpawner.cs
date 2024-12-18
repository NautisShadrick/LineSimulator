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
    [AddComponentMenu("Lua/PlayerCharacterSpawner")]
    [LuaRegisterType(0x86c889f16f49fd6d, typeof(LuaBehaviour))]
    public class PlayerCharacterSpawner : LuaBehaviourThunk
    {
        private const string s_scriptGUID = "88de721fb90843944b4f498ca102c1b3";
        public override string ScriptGUID => s_scriptGUID;

        [SerializeField] public UnityEngine.GameObject m_characterPrefab = default;

        protected override SerializedPropertyValue[] SerializeProperties()
        {
            if (_script == null)
                return Array.Empty<SerializedPropertyValue>();

            return new SerializedPropertyValue[]
            {
                CreateSerializedProperty(_script.GetPropertyAt(0), m_characterPrefab),
            };
        }
    }
}

#endif
