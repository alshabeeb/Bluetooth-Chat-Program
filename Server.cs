﻿using System;
using System.IO.Ports;	// needed for the SerialPort class

namespace Bluetooth_Chat_server
{
	class Server
	{
		public static void Main (string[] args)
		{

			const string COM_PORT = "COM#";	/* replace the # with the COM Port number corresponding to your
									       established virtual COM Port number; e.g., COM1, COM12, etc... */

			const int BAUD_RATE = 9600;	/* 9600 MHz for baud rate, we'll discuss this value later */


			SerialPort sp = new SerialPort (COM_PORT, BAUD_RATE);	/* Establish an instantiation of SerialPort class that
																	   reads off Com Port @COM_PORT at @BAUD_RATE MHz */

			sp.Open ();		/* Open the desired COM Port
							 * Note: The program will crash at this line if you specify the wrong COM Port or Baud Rate
							*/

			while (true)	// Infinite loop
				Console.WriteLine (sp.ReadLine());	/* Print received input from Client Bluetooth device */
		}	// EOF Main.. Note: EOF stands for End OF
	}	// EOF @Server
}	// EOF @BluetoothChat
