﻿using System;

namespace ConferenceManagementSystem.Common.Helpers
{
    public static class HandleGenerator {
        private static readonly Random Rnd = new Random(DateTime.UtcNow.Millisecond);
        private static readonly char[] AllowableChars = "ABCDEFGHJKMNPQRSTUVWXYZ123456789".ToCharArray();

        public static string Generate(int length)
        {
            var result = new char[length];
            lock (Rnd) {
                for (var i = 0; i < length; i++) {
                    result[i] = AllowableChars[Rnd.Next(0, AllowableChars.Length)];
                }
            }

            return new string(result);
        }
    }
}
