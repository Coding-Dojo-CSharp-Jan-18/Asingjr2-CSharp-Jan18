using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ajax_linq_session_recap.SessionExtension
{
    public static class SessionExtension
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}

/* *********************************************************
    Important session methods are set string, get string, set int32, get int32, set object, get object
   ***********************************************************
 */