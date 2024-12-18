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
    [AddComponentMenu("Lua/SceneLoader")]
    [LuaRegisterType(0x715f6ba4a20ae1f0, typeof(LuaBehaviour))]
    public class SceneLoader : LuaBehaviourThunk
    {
        private const string s_scriptGUID = "52d136e1bf610f743ab7b9bed32a8ec8";
        public override string ScriptGUID => s_scriptGUID;


        protected override SerializedPropertyValue[] SerializeProperties()
        {
            if (_script == null)
                return Array.Empty<SerializedPropertyValue>();

            return new SerializedPropertyValue[]
            {
            };
        }
    }
}

#endif
