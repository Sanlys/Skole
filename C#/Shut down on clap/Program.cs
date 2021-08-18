using System;
using NAudio.CoreAudioApi;
using System.Collections.Generic;
using NAudio.Wave;
using System.Xml.Schema;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class CommandLine
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("Kernel32")]
        private static extern IntPtr GetConsoleWindow();

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        static void Main(string[] args)
        {

            IntPtr hwnd;
            hwnd = GetConsoleWindow();
            ShowWindow(hwnd, SW_HIDE);

            var recorder = new WaveInEvent();
            recorder.StartRecording();
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            int i = 0;

            while (true)
            {
                var device = devices[i];
                
                device.AudioEndpointVolume.Mute = false;
                if (device.AudioMeterInformation.MasterPeakValue > 0.5)
                {
                    ProcessStartInfo shutdown = new ProcessStartInfo("shutdown", " /s /t 0");
                    shutdown.CreateNoWindow = true;
                    shutdown.UseShellExecute = false;
                    Process.Start(shutdown);
                }
                System.Threading.Thread.Sleep(1000);
                i++;
                if (i == devices.Count)
                {
                    i = 0;
                }
            }
        }
    }
}