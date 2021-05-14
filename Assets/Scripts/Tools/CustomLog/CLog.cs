using System;
using UnityEngine;

namespace Tools {
    public class CLog
    {
        public static void Info(String message)
        {
            Debug.Log(message);
        }

        public static void Warning(String message)
        {
            Debug.LogWarning(message);
        }

        public static void Error(String message)
        {
            Debug.LogError(message);
        }

    }
}
