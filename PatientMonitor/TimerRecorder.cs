﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Resources;

namespace PatientMonitor
{
    class TimerRecorder
    {

        public TimerRecorder()
        {

        }
        //collect timer data from Alarm Above
        AlarmAbove alarmAbove = new AlarmAbove();

        //Collect timer data from Alarm Below
        AlarmBelow alarmBelow = new AlarmBelow();

        /// <summary>
        /// Write timers to CSV
        /// </summary>
        public void csvWriter(string timer)
        {
            // Path to save file
            string fileAddress = "Timer Records.csv";

            // Time record delimiter
            string delimiter = ",";

            // Create an array to store time
            string[] timeData = new string[] { "Time taken to disable alarm:", timer };

            // Build CSV string to use for the array
            StringBuilder stringbuild = new StringBuilder();
            stringbuild.AppendLine(string.Join(delimiter, timer));

            // Append string to file
            File.AppendAllText(fileAddress, stringbuild.ToString());
        }
    }
}