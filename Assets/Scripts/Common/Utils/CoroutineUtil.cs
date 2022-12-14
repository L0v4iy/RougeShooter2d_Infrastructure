using System;
using System.Collections;
using UnityEngine;

namespace Common.util
{
    public static class CoroutineUtil
    {
        /*/**
      * Usage: StartCoroutine(CoroutineUtils.Chain(...))
      * For example:
      *     StartCoroutine(CoroutineUtils.Chain(
      *         CoroutineUtils.Do(() => Debug.Log("A")),
      *         CoroutineUtils.WaitForSeconds(2),
      *         CoroutineUtils.Do(() => Debug.Log("B"))));
      #1#
        public static IEnumerator<T> Chain<T>(params IEnumerator[] actions) {
            foreach (IEnumerator action in actions) {
                yield return SomeSingletonGO.instance.StartCoroutine(action);
            }
        }*/

        /**
      * Usage: StartCoroutine(CoroutineUtils.DelaySeconds(action, delay))
      * For example:
      *     StartCoroutine(CoroutineUtils.DelaySeconds(
      *         () => DebugUtils.Log("2 seconds past"),
      *         2);
         */
        public static IEnumerator DelaySeconds(Action action, float delay)
        {
            yield return new WaitForSeconds(delay);
            action();
        }

        public static IEnumerator WaitForSeconds(float time)
        {
            yield return new WaitForSeconds(time);
        }

        public static IEnumerator Do(Action action)
        {
            action();
            yield return 0;
        }
    }
}