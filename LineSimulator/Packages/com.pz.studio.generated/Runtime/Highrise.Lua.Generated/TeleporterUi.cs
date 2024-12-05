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
    [AddComponentMenu("Lua/TeleporterUi")]
    [LuaRegisterType(0x3c28d6dc4d72cb47, typeof(LuaBehaviour))]
    public class TeleporterUi : LuaBehaviourThunk
    {
        private const string s_scriptGUID = "adfb05b985c60f4429f5225b109214ac";
        public override string ScriptGUID => s_scriptGUID;


        protected override SerializedPropertyValue[] SerializeProperties()
        {
            if (_script == null)
                return Array.Empty<SerializedPropertyValue>();

            return new SerializedPropertyValue[]
            {
                CreateSerializedProperty(_script.GetPropertyAt(0), null),
            };
        }
    }
}

#endif
