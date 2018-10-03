﻿using System.Diagnostics;

/**
 * This is a plugin that runs a command in windows. It can be anything that you would run using command line prompt.
 * 
 * It has only one method
 * 
 * 1) RUN
 *    . command: the complete command lina that will be executed by the plugin
 * 
 * Please refer to OptiKey wiki for more information on registering and developing extensions.
 */

namespace JuliusSweetland.OptiKey.StandardPlugins
{
    public class ExternalProgram
    {
        // Simply run it.
        public void RUN(string command)
        {
            Process.Start(command);
        }
    }
}
