﻿using UnityEngine;

namespace Singleton
{
    public class ASingletonPersistentInvoker : MonoBehaviour
    {
        [Button]
        void PrintRandomValue() => ASingletonPersistent.Instance.PrintRandomValue();
    }
}