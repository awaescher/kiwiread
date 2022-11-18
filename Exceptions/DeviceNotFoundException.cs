﻿namespace kiwiread.Exceptions;

public class DeviceNotFoundException : KiwiException
{
    public DeviceNotFoundException(string? deviceName, Exception? innerException) : base($"Device \"{deviceName}\" could not be found.", innerException)
    {
    }
}
