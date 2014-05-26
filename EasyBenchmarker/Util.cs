/*
 ****************************************************************************
 * AGILENT TECHNOLOGIES
 * Created : Sept 2013
 * Author: Marc Tapalla
 * Organization: Microwave Communications Division
 *   
 * No part of this program may be photocopied, reproduced or translated to
 * another program language without the prior written consent of Agilent Technologies.
 * 
 * Copyright 2007 Agilent Technologies.  All rights reserved.
 * 
 ****************************************************************************
 */

using System;

namespace SpeedSquadLib
{
    public static class Util
    {
        /// <summary>
        /// If "Settings.DebugMode" is true, System.Console" will write debug messages using this method.
        /// </summary>
        public static void Debug(string message)
        {
            if (Settings.DebugMode)
                Console.WriteLine(message);
        }

        /// <summary>
        /// Enable "Settings.DebugMode"
        /// </summary>
        public static void EnableDebug()
        {
            Settings.DebugMode = true;
        }

        /// <summary>
        /// Disable "Settings.DebugMode"
        /// </summary>
        public static void DisableDebug()
        {
            Settings.DebugMode = false;
        }

        /// <summary>
        /// Toggle state of "Settings.DebugMode"
        /// </summary>
        public static void ToggleDebug()
        {
            Settings.DebugMode = !Settings.DebugMode;
        }
    }
}